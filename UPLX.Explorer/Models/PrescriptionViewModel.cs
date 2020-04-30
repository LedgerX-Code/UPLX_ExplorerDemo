using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPLX.Explorer.Models
{
    public class PrescriptionViewModel
    {
        public string PatientId { get; set; }
        public string DrugName { get; set; }
        public string DrugType { get; set; }
        public string Dose { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string VisitCode { get; set; }
        public string Facility { get; set; }
        public string Route { get; set; }
        public string Frequency { get; set; }
    }
}
