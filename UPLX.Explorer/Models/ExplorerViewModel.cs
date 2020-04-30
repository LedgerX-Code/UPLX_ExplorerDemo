using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPLX.Explorer.Service.Models;

namespace UPLX.Explorer.Models
{
    public class ExplorerViewModel
    {
        public string DataType { get; set; } = Constants.Patient;
        public string[] DataTypes = new[] { Constants.Patient, Constants.Consultation, Constants.Prescription, Constants.Issue };
        public string Unit { get; set; }
        public string Value { get; set; }
        public string Field { get; set; }
        public List<SelectListItem> Fields { get; set; }
        public List<PatientModel> Patients { get; set; } = new List<PatientModel>();
        public List<ConsultationModel> Consultations { get; set; } = new List<ConsultationModel>();
        public List<PrescriptionModel> Prescriptions { get; set; } = new List<PrescriptionModel>();

        //Dashboard
        public int TotalPatients { get; set; }
        public int TotalTransactions { get; set; }
        public int TotalIssues { get; set; }
        public int TotalFacilities { get; set; }
    }
}
