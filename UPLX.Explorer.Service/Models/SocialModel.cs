using Newtonsoft.Json;

namespace UPLX.Explorer.Service.Models
{
    public class SocialModel
    {
        [JsonProperty(PropertyName = "socialId")]
        public string SocialId { get; set; }

        [JsonProperty(PropertyName = "maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty(PropertyName = "dependency")]
        public string Dependency { get; set; }

        [JsonProperty(PropertyName = "ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty(PropertyName = "incomeStatus")]
        public string IncomeStatus { get; set; }

        [JsonProperty(PropertyName = "income")]
        public long Income { get; set; }

        [JsonProperty(PropertyName = "insuranceType")]
        public string InsuranceType { get; set; }

        [JsonProperty(PropertyName = "religon")]
        public string Religon { get; set; }

        [JsonProperty(PropertyName = "employmentStatus")]
        public string EmploymentStatus { get; set; }

        [JsonProperty(PropertyName = "criminalBackground")]
        public string CriminalBackground { get; set; }

        [JsonProperty(PropertyName = "geneticHistory")]
        public string GeneticHistory { get; set; }

        [JsonProperty(PropertyName = "languageSpoken")]
        public string LanguageSpoken { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public long CreatedDate { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }

        [JsonProperty(PropertyName = "educationLevel")]
        public string EducationLevel { get; set; }
    }
}