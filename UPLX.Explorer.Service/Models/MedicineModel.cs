using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class MedicineModel
    {
        [JsonProperty(PropertyName = "drugName")]
        public string DrugName { get; set; }

        [JsonProperty(PropertyName = "drugType")]
        public string DrugType { get; set; }

        [JsonProperty(PropertyName = "dose")]
        public string Dose { get; set; }

        [JsonProperty(PropertyName = "route")]
        public string Route { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        [JsonProperty(PropertyName = "validityOfDrug")]
        public long ValidityOfDrug { get; set; }

        [JsonProperty(PropertyName = "startedDate")]
        public long StartedDate { get; set; }

        [JsonProperty(PropertyName = "endedDate")]
        public long EndedDate { get; set; }
    }
}
