using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class ExplorerRequestModel
    {
        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }
    }
}
