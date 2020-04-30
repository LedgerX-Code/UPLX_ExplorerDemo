using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPLX.Explorer.Service.Models;

namespace UPLX.Explorer.Models
{
    public class PatientViewModel
    {
        public string PatientId { get; set; }
        public TransactionDetailModel<PatientModel> Patient { get; set; } = new TransactionDetailModel<PatientModel>();
        public List<TransactionDetailModel<PatientModel>> PatientTrxns { get; set; } = new List<TransactionDetailModel<PatientModel>>();
        public List<TransactionDetailModel<ConsultationModel>> ConsultTrxns { get; set; } = new List<TransactionDetailModel<ConsultationModel>>();
        public List<TransactionDetailModel<PrescriptionModel>> PrescriptTrxns { get; set; } = new List<TransactionDetailModel<PrescriptionModel>>();
        public List<TransactionDetailModel<IssueModel>> IssueTrxns { get; set; } = new List<TransactionDetailModel<IssueModel>>();
        public List<TransactionDetailModel<TriageModel>> TriageTrxns { get; set; } = new List<TransactionDetailModel<TriageModel>>();
    }
}
