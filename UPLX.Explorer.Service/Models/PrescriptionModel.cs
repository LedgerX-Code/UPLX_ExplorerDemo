using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class PrescriptionModel
    {
        [JsonProperty(PropertyName = "consultationId")]
        public string ConsultationId { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }

        [JsonProperty(PropertyName = "procedureId")]
        public string ProcedureId { get; set; }

        [JsonProperty(PropertyName = "visitCode")]
        public string VisitCode { get; set; }

        [JsonProperty(PropertyName = "doctorLicenseNo")]
        public string DoctorLicenseNo { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "medicines")]
        public List<MedicineModel> Medicines { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "facility")]
        public string Facility { get; set; }
    }
}
