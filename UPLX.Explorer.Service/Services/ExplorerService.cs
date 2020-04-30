using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPLX.Explorer.Service.Models;

namespace UPLX.Explorer.Service.Services
{
    public class ExplorerService
    {
        public async Task<List<PatientModel>> FilterPatientsByDataType(IConfiguration config, string[] dataFields, string[] values)
        {
            string nullValue = "Null";
            decimal alcoholValue = 0, fitnessHours = 0;
            Dictionary<string, string> paras = new Dictionary<string, string>();
            for (int i = 0; i < dataFields.Count(); i++)
            {
                if(!paras.ContainsKey(dataFields[i]) && !string.IsNullOrEmpty(values[i]))
                    paras.Add(dataFields[i], values[i]);
            }

            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.FilterPatients(
                    paras.ContainsKey(Constants.PatientConstant.bodyType) ? paras[Constants.PatientConstant.bodyType] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.bloodCode) ? paras[Constants.PatientConstant.bloodCode] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.allergies) ? paras[Constants.PatientConstant.allergies] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.gender) ? paras[Constants.PatientConstant.gender] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.smokingFrequency) ? paras[Constants.PatientConstant.smokingFrequency] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.alcoholUnit) ? paras[Constants.PatientConstant.alcoholUnit] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.alcoholValue) ? decimal.Parse(paras[Constants.PatientConstant.alcoholValue]) : alcoholValue,
                    paras.ContainsKey(Constants.PatientConstant.weeklyFitnessHours) ? decimal.Parse(paras[Constants.PatientConstant.weeklyFitnessHours]) : fitnessHours,
                    paras.ContainsKey(Constants.PatientConstant.postCode) ? paras[Constants.PatientConstant.postCode] : nullValue,
                    paras.ContainsKey(Constants.PatientConstant.nationality) ? paras[Constants.PatientConstant.nationality] : nullValue,
                    nullValue,
                    paras.ContainsKey(Constants.PatientConstant.accessibilityToHospital) ? paras[Constants.PatientConstant.accessibilityToHospital] : nullValue
                );
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<List<ConsultationModel>> FilterConsultationsByDataType(IConfiguration config, string[] dataFields, string[] values)
        {
            string nullValue = "Null";
            Dictionary<string, string> paras = new Dictionary<string, string>();
            for (int i = 0; i < dataFields.Count(); i++)
            {
                if (!paras.ContainsKey(dataFields[i]) && !string.IsNullOrEmpty(values[i]))
                    paras.Add(dataFields[i], values[i]);
            }

            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.FilterConsultations(
                    paras.ContainsKey(Constants.ConsultationConstant.facility) ? paras[Constants.ConsultationConstant.facility] : nullValue,
                    paras.ContainsKey(Constants.ConsultationConstant.category) ? paras[Constants.ConsultationConstant.category] : nullValue,
                    paras.ContainsKey(Constants.ConsultationConstant.department) ? paras[Constants.ConsultationConstant.department] : nullValue,
                    paras.ContainsKey(Constants.ConsultationConstant.consOutcome) ? paras[Constants.ConsultationConstant.consOutcome] : nullValue,
                    paras.ContainsKey(Constants.ConsultationConstant.remarks) ? paras[Constants.ConsultationConstant.remarks] : nullValue
                );
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<List<ConsultationModel>> GetAllConsultations(IConfiguration config)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.GetAllConsultations();
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<int> TotalFacilityInConsultation(IConfiguration config)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                var consults = await api.GetAllConsultations();
                return consults.GroupBy(c => c.Facility).Count();
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<List<PrescriptionModel>> FilterPrescriptionsByDataType(IConfiguration config, string[] dataFields, string[] values)
        {
            string nullValue = "Null";
            Dictionary<string, string> paras = new Dictionary<string, string>();
            for (int i = 0; i < dataFields.Count(); i++)
            {
                if (!paras.ContainsKey(dataFields[i]) && !string.IsNullOrEmpty(values[i]))
                    paras.Add(dataFields[i], values[i]);
            }

            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.FilterPrescriptions(
                    paras.ContainsKey(Constants.PrescriptionConstant.drugName) ? paras[Constants.PrescriptionConstant.drugName] : nullValue,
                    paras.ContainsKey(Constants.PrescriptionConstant.drugType) ? paras[Constants.PrescriptionConstant.drugType] : nullValue,
                    paras.ContainsKey(Constants.PrescriptionConstant.dose) ? paras[Constants.PrescriptionConstant.dose] : nullValue,
                    paras.ContainsKey(Constants.PrescriptionConstant.frequency) ? paras[Constants.PrescriptionConstant.frequency] : nullValue,
                    paras.ContainsKey(Constants.PrescriptionConstant.route) ? paras[Constants.PrescriptionConstant.route] : nullValue,
                    paras.ContainsKey(Constants.PrescriptionConstant.description) ? paras[Constants.PrescriptionConstant.description] : nullValue
                );
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<int> TotalPatients(IConfiguration config)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.TotalPatients();
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<int> TotalTransactions(IConfiguration config)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.TotalTransactions();
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<int> TotalIssues(IConfiguration config)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.TotalIssues();
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<List<IssueModel>> FilterIssuesByDataType(IConfiguration config, string[] dataFields, string[] values)
        {
            string nullValue = "Null";
            Dictionary<string, string> paras = new Dictionary<string, string>();
            for (int i = 0; i < dataFields.Count(); i++)
            {
                if (!paras.ContainsKey(dataFields[i]) && !string.IsNullOrEmpty(values[i]))
                    paras.Add(dataFields[i], values[i]);
            }

            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.FilterIssues(
                    paras.ContainsKey(Constants.IssueConstant.issueType) ? paras[Constants.IssueConstant.issueType] : nullValue,
                    paras.ContainsKey(Constants.IssueConstant.issueTitle) ? paras[Constants.IssueConstant.issueTitle] : nullValue
                );
            }
            catch (ApiException ex)
            {
                throw;
            }
        }

        public async Task<List<TransactionDetailModel<object>>> GetAllPatientTrxns(IConfiguration config, ExplorerRequestModel model)
        {
            try
            {
                ApiGateway api = new ApiGateway(config);
                return await api.GetAllPatientTrxns(model);
            }
            catch (ApiException ex)
            {
                throw;
            }
        }
    }
}
