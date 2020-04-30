using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPLX.Explorer.Service.Models;

namespace UPLX.Explorer.Service
{
    [Headers("Authorization: Bearer")]
    public interface IApiGateway
    {
        [Get("/api/explorer/patient/filterByDataType")]
        Task<List<PatientModel>> FilterPatients(string bodyType, string bloodCode, string allergies, string gender, string smokingFrequency, string alcoholUnit, decimal alcoholValue,
                                                        decimal fitnessHours, string postCode, string nationality, string birthPlace, string toHospital);
        [Get("/api/explorer/consultation/filterByDataType")]
        Task<List<ConsultationModel>> FilterConsultations(string facility, string category, string department, string consOut, string remarks);
        [Get("/api/explorer/consultation/all")]
        Task<List<ConsultationModel>> GetAllConsultations();
        [Get("/api/explorer/prescription/filterByDataType")]
        Task<List<PrescriptionModel>> FilterPrescriptions(string drugName, string drugType, string dose, string frequency, string route, string des);

        [Get("/api/explorer/patient/total")]
        Task<int> TotalPatients();
        [Get("/api/explorer/historian/total")]
        Task<int> TotalTransactions();
        [Get("/api/explorer/issue/total")]
        Task<int> TotalIssues();
        [Get("/api/explorer/issue/filterByDataType")]
        Task<List<IssueModel>> FilterIssues(string type, string title);
        [Post("/api/explorer/patient/getalltrxns")]
        Task<List<TransactionDetailModel<object>>> GetAllPatientTrxns([Body] ExplorerRequestModel model);
    }
}
