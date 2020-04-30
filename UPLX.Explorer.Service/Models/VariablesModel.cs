using Newtonsoft.Json;

namespace UPLX.Explorer.Service.Models
{
    public class VariablesModel
    {
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "healthCard")]
        public string HealthCard { get; set; }

        [JsonProperty(PropertyName = "dietaryRestrictions")]
        public string DietaryRestrictions { get; set; }

        [JsonProperty(PropertyName = "smokingFrequency")]
        public string SmokingFrequency { get; set; }

        [JsonProperty(PropertyName = "alcoholConsumption")]
        public AlcoholConsumptionModel AlcoholConsumption { get; set; }

        [JsonProperty(PropertyName = "weeklyFitnessHours")]
        public int WeeklyFitnessHours { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public long CreatedDate { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }
    }
}