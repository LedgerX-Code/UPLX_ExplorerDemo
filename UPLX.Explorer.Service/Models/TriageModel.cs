using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class TriageModel
    {
        [JsonProperty(PropertyName = "triageId")]
        public string TriageId { get; set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }

        [JsonProperty(PropertyName = "visitType")]
        public string VisitType { get; set; }

        [JsonProperty(PropertyName = "visitCode")]
        public string VisitCode { get; set; }

        [JsonProperty(PropertyName = "consultationId")]
        public string ConsultationId { get; set; }

        [JsonProperty(PropertyName = "nurseId")]
        public string NurseId { get; set; }

        [JsonProperty(PropertyName = "doctorLicenseNo")]
        public string DoctorLicenseNo { get; set; }

        [JsonProperty(PropertyName = "triageDate")]
        public long TriageDate { get; set; }

        [JsonProperty(PropertyName = "temperature")]
        public List<HealthRateModel> Temperature { get; set; }

        [JsonProperty(PropertyName = "respiroty")]
        public List<HealthRateModel> Respiroty { get; set; }

        [JsonProperty(PropertyName = "heartRate")]
        public List<HealthRateModel> HeartRate { get; set; }

        [JsonProperty(PropertyName = "bloodPressure")]
        public List<HealthRateModel> BloodPressure { get; set; }

        [JsonProperty(PropertyName = "oxygen")]
        public List<HealthRateModel> Oxygen { get; set; }

        [JsonProperty(PropertyName = "sugarLevel")]
        public List<HealthRateModel> SugarLevel { get; set; }

        [JsonProperty(PropertyName = "height")]
        public List<HealthRateModel> Height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public List<HealthRateModel> Weight { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public string Fee { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }

    public class HealthRateModel
    {
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
