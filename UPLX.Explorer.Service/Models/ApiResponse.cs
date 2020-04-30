using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class ApiResponse
    {
        public PrescriptionModel Prescription { get; set; }
        public PatientModel Patient { get; set; }
        public ConsultationModel Consultation { get; set; }
        public IssueModel Issue { get; set; }
        public TriageModel Triage { get; set; }
    }
}
