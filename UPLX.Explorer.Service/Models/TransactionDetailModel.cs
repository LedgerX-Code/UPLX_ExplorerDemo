using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class TransactionDetailModel<T>
    {
        [JsonProperty(PropertyName = "transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "events")]
        public List<T> Events { get; set; }

        [JsonProperty(PropertyName = "transactionTimestamp")]
        public string TransactionTimestamp { get; set; }
    }
}
