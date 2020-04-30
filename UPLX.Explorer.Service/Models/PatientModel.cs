using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class PatientModel
    {
        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }

        [JsonProperty(PropertyName = "bloodCode")]
        public string BloodCode { get; set; }

        [JsonProperty(PropertyName = "bodyType")]
        public string BodyType { get; set; }

        [JsonProperty(PropertyName = "geneticSyndromes")]
        public string GeneticSyndromes { get; set; }

        [JsonProperty(PropertyName = "allergies")]
        public string Allergies { get; set; }

        [JsonProperty(PropertyName = "genderOfOrigin")]
        public string GenderOfOrigin { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public long CreatedDate { get; set; }

        [JsonProperty(PropertyName = "authorized")]
        public List<string> Authorized { get; set; }

        [JsonProperty(PropertyName = "variables")]
        public VariablesModel Variables { get; set; }

        [JsonProperty(PropertyName = "location")]
        public LocationModel Location { get; set; }

        [JsonProperty(PropertyName = "social")]
        public SocialModel Social { get; set; }

        [JsonProperty(PropertyName = "dateOfDeath")]
        public long DateOfDeath { get; set; }

        [JsonProperty(PropertyName = "reasonOfDeath")]
        public string ReasonOfDeath { get; set; }
    }
}
