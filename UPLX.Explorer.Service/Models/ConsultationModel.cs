using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class ConsultationModel
    {
        [JsonProperty(PropertyName = "doctorLicenseNo")]
        public string DoctorLicenseNo { get; set; }

        [JsonProperty(PropertyName = "orgLicenseNo")]
        public string OrgLicenseNo { get; set; }

        [JsonProperty(PropertyName = "orgCountry")]
        public string OrgCountry { get; set; }

        [JsonProperty(PropertyName = "consultedDate")]
        public long ConsultedDate { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "departments")]
        public List<string> Departments { get; set; }

        [JsonProperty(PropertyName = "visitCode")]
        public string VisitCode { get; set; }

        [JsonProperty(PropertyName = "visitType")]
        public string VisitType { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "consOutcome")]
        public string ConsOutcome { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public long Fee { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "facility")]
        public string Facility { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }
    }
}
