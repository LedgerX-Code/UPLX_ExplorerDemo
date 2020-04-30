using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using UPLX.Explorer.Models;
using UPLX.Explorer.Service.Models;
using UPLX.Explorer.Service.Services;

namespace UPLX.Explorer.Controllers
{
    public class PatientController : Controller
    {
        private IConfiguration configuration;
        public PatientController(IConfiguration _config)
        {
            configuration = _config;
        }

        public async Task<IActionResult> Index(string patientId)
        {
            try
            {
                PatientViewModel model = new PatientViewModel();
                if (!string.IsNullOrEmpty(patientId))
                {
                    ExplorerRequestModel request = new ExplorerRequestModel();
                    request.PatientId = patientId;
                    model.PatientId = patientId;

                    ExplorerService service = new ExplorerService();
                    var data = await service.GetAllPatientTrxns(configuration, request);
                    foreach (var d in data)
                    {
                        switch (d.TransactionType)
                        {
                            case Constants.TransactionType.CreatePatient:
                                model.Patient.TransactionId = d.TransactionId;
                                model.Patient.TransactionTimestamp = d.TransactionTimestamp;
                                model.Patient.TransactionType = d.TransactionType;
                                model.Patient.Events = new List<PatientModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    model.Patient.Events.Add(p.Patient);
                                }

                                model.PatientTrxns.Add(model.Patient);
                                break;
                            case Constants.TransactionType.ChangePatient:
                                TransactionDetailModel<PatientModel> patient = new TransactionDetailModel<PatientModel>();
                                patient.TransactionId = d.TransactionId;
                                patient.TransactionTimestamp = d.TransactionTimestamp;
                                patient.TransactionType = d.TransactionType;
                                patient.Events = new List<PatientModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    patient.Events.Add(p.Patient);
                                }

                                model.PatientTrxns.Add(patient);
                                break;
                            case Constants.TransactionType.Consult:
                                TransactionDetailModel<ConsultationModel> consult = new TransactionDetailModel<ConsultationModel>();
                                consult.TransactionId = d.TransactionId;
                                consult.TransactionTimestamp = d.TransactionTimestamp;
                                consult.TransactionType = d.TransactionType;
                                consult.Events = new List<ConsultationModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    consult.Events.Add(p.Consultation);
                                }

                                model.ConsultTrxns.Add(consult);
                                break;
                            case Constants.TransactionType.Prescription:
                                TransactionDetailModel<PrescriptionModel> prescript = new TransactionDetailModel<PrescriptionModel>();
                                prescript.TransactionId = d.TransactionId;
                                prescript.TransactionTimestamp = d.TransactionTimestamp;
                                prescript.TransactionType = d.TransactionType;
                                prescript.Events = new List<PrescriptionModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    prescript.Events.Add(p.Prescription);
                                }

                                model.PrescriptTrxns.Add(prescript);
                                break;
                            case Constants.TransactionType.CreateIssue:
                                TransactionDetailModel<IssueModel> issue = new TransactionDetailModel<IssueModel>();
                                issue.TransactionId = d.TransactionId;
                                issue.TransactionTimestamp = d.TransactionTimestamp;
                                issue.TransactionType = d.TransactionType;
                                issue.Events = new List<IssueModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    issue.Events.Add(p.Issue);
                                }

                                model.IssueTrxns.Add(issue);
                                break;
                            case Constants.TransactionType.CreateTest:
                                break;
                            case Constants.TransactionType.CreateTriage:
                                TransactionDetailModel<TriageModel> triage = new TransactionDetailModel<TriageModel>();
                                triage.TransactionId = d.TransactionId;
                                triage.TransactionTimestamp = d.TransactionTimestamp;
                                triage.TransactionType = d.TransactionType;
                                triage.Events = new List<TriageModel>();
                                foreach (var e in d.Events)
                                {
                                    var p = JsonConvert.DeserializeObject<ApiResponse>(e.ToString());
                                    triage.Events.Add(p.Triage);
                                }

                                model.TriageTrxns.Add(triage);
                                break;
                            case Constants.TransactionType.CreateProcedure:
                                break;
                        }
                    }
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ViewData["Message"] = "Could not get patient data. Please try again later.";
            }

            return View();
        }
    }
}