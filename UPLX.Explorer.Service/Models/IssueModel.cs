using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service.Models
{
    public class IssueModel
    {
        [JsonProperty(PropertyName = "issueId")]
        public string IssueId { get; set; }

        [JsonProperty(PropertyName = "issueType")]
        public string IssueType { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "visitType")]
        public string VisitType { get; set; }

        [JsonProperty(PropertyName = "visitCode")]
        public string VisitCode { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public string PatientId { get; set; }

        [JsonProperty(PropertyName = "consultationId")]
        public string ConsultationId { get; set; }

        [JsonProperty(PropertyName = "issueDate")]
        public long IssueDate { get; set; }

        [JsonProperty(PropertyName = "beginDate")]
        public long BeginDate { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public long EndDate { get; set; }

        [JsonProperty(PropertyName = "occurrence")]
        public string Occurrence { get; set; }

        [JsonProperty(PropertyName = "referredBy")]
        public string ReferredBy { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "outCome")]
        public string OutCome { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
