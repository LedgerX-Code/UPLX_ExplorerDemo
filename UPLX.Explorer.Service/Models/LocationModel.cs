using Newtonsoft.Json;

namespace UPLX.Explorer.Service.Models
{
    public class LocationModel
    {
        [JsonProperty(PropertyName = "postCode")]
        public string PostCode { get; set; }

        [JsonProperty(PropertyName = "district")]
        public string District { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName = "birthPlace")]
        public string BirthPlace { get; set; }

        [JsonProperty(PropertyName = "accessibilityToHospital")]
        public string AccessibilityToHospital { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public long CreatedDate { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }
    }
}