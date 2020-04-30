using Newtonsoft.Json;

namespace UPLX.Explorer.Service.Models
{
    public class AlcoholConsumptionModel
    {
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
    }
}