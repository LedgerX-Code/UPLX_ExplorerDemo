using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using UPLX.Explorer.Models;
using UPLX.Explorer.Service;
using UPLX.Explorer.Service.Services;
using Constants = UPLX.Explorer.Models.Constants;

namespace UPLX.Explorer.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        public HomeController(IConfiguration _config)
        {
            configuration = _config;
        }

        public async Task<IActionResult> Index(string type)
        {
            type = string.IsNullOrEmpty(type) ? Constants.Patient : type;
            ExplorerViewModel model = new ExplorerViewModel();
            model.DataType = type;
            model.Fields = GetFields(type);

            //Get total patients
            ExplorerService service = new ExplorerService();
            model.TotalPatients = await service.TotalPatients(configuration);
            model.TotalTransactions = await service.TotalTransactions(configuration);
            model.TotalIssues = await service.TotalIssues(configuration);
            model.TotalFacilities = await service.TotalFacilityInConsultation(configuration);

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Search(ExplorerViewModel model, IFormCollection form)
        {
            string[] fields = form["Field"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] values = form["Value"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            ExplorerService service = new ExplorerService();
            try
            {
                if (model.DataType.Equals(Constants.Patient))
                {
                    var patients = await service.FilterPatientsByDataType(configuration, fields, values);

                    return Json(new { type = model.DataType, data = patients });
                }

                if (model.DataType.Equals(Constants.Consultation))
                {
                    var consults = await service.FilterConsultationsByDataType(configuration, fields, values);
                    
                    return Json(new { type = model.DataType, data = consults });
                }

                if (model.DataType.Equals(Constants.Prescription))
                {
                    List<PrescriptionViewModel> result = new List<PrescriptionViewModel>();
                    var prescriptions = await service.FilterPrescriptionsByDataType(configuration, fields, values);
                    foreach (var p in prescriptions)
                    {
                        foreach(var m in p.Medicines)
                        {
                            PrescriptionViewModel prescription = new PrescriptionViewModel
                            {
                                PatientId = p.PatientId,
                                Description = p.Description,
                                Dose = m.Dose,
                                DrugName = m.DrugName,
                                DrugType = m.DrugType,
                                Facility = p.Facility,
                                Frequency = m.Frequency,
                                Quantity = m.Quantity,
                                Route = m.Route,
                                VisitCode = p.VisitCode
                            };
                            result.Add(prescription);
                        }
                    }

                    return Json(new { type = model.DataType, data = result });
                }

                if (model.DataType.Equals(Constants.Issue))
                {
                    var issues = await service.FilterIssuesByDataType(configuration, fields, values);

                    return Json(new { type = model.DataType, data = issues });
                }

            }
            catch(Exception ex)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            

            model.Fields = GetFields(model.DataType);
            return View("Index",model);
        }

        private List<SelectListItem> GetFields(string dataType)
        {
            switch (dataType)
            {
                case Constants.Patient:
                    return new List<SelectListItem> {
                        new SelectListItem(Constants.PatientConstant.BodyType, Constants.PatientConstant.bodyType, true),
                        new SelectListItem(Constants.PatientConstant.BloodCode, Constants.PatientConstant.bloodCode, false),
                        //new SelectListItem(Constants.PatientConstant.Allergies, Constants.PatientConstant.allergies, false),
                        new SelectListItem(Constants.PatientConstant.Gender, Constants.PatientConstant.gender, false),
                        new SelectListItem(Constants.PatientConstant.Nationality, Constants.PatientConstant.nationality, false),
                        new SelectListItem(Constants.PatientConstant.PostalCode, Constants.PatientConstant.postCode, false),
                        //new SelectListItem(Constants.PatientConstant.SmokingFrequency, Constants.PatientConstant.smokingFrequency, false),
                        //new SelectListItem(Constants.PatientConstant.WeeklyFitnessHours, Constants.PatientConstant.weeklyFitnessHours, false),
                        new SelectListItem(Constants.PatientConstant.AccessibilityToHospital, Constants.PatientConstant.accessibilityToHospital, false),
                        new SelectListItem(Constants.PatientConstant.BirthPlace, Constants.PatientConstant.birthPlace, false),
                        //new SelectListItem(Constants.PatientConstant.WeeklyAlcoholConsumption, Constants.PatientConstant.alcoholValue, false)
                    };
                case Constants.Consultation:
                    return new List<SelectListItem> {
                        new SelectListItem(Constants.ConsultationConstant.Facility, Constants.ConsultationConstant.facility, true),
                        new SelectListItem(Constants.ConsultationConstant.Category, Constants.ConsultationConstant.category, false),
                        new SelectListItem(Constants.ConsultationConstant.Department, Constants.ConsultationConstant.department, false),
                        //new SelectListItem(Constants.ConsultationConstant.ConsultedDate, Constants.ConsultationConstant.consultedDate, false),
                        new SelectListItem(Constants.ConsultationConstant.ConsOutcome, Constants.ConsultationConstant.consOutcome, false),
                        new SelectListItem(Constants.ConsultationConstant.Remarks, Constants.ConsultationConstant.remarks, false)
                    };
                case Constants.Prescription:
                    return new List<SelectListItem> {
                        new SelectListItem(Constants.PrescriptionConstant.DrugName, Constants.PrescriptionConstant.drugName, true),
                        new SelectListItem(Constants.PrescriptionConstant.DrugType, Constants.PrescriptionConstant.drugType, false),
                        new SelectListItem(Constants.PrescriptionConstant.Dose, Constants.PrescriptionConstant.dose, false),
                        new SelectListItem(Constants.PrescriptionConstant.Description, Constants.PrescriptionConstant.description, false),
                        new SelectListItem(Constants.PrescriptionConstant.Frequency, Constants.PrescriptionConstant.frequency, false),
                        new SelectListItem(Constants.PrescriptionConstant.Route, Constants.PrescriptionConstant.route, false)
                    };
                case Constants.Issue:
                    return new List<SelectListItem> {
                        new SelectListItem(Constants.IssueConstant.IssueType, Constants.IssueConstant.issueType, true),
                        new SelectListItem(Constants.IssueConstant.IssueTitle, Constants.IssueConstant.issueTitle, false)
                    };
            }
            
            return new List<SelectListItem>();
        }
    }
}
