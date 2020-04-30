using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UPLX.Explorer.Service.Models;

namespace UPLX.Explorer.Service
{
    public class ApiGateway
    {
        private IApiGateway _api;
        private IConfiguration configuration;
        public ApiGateway(IConfiguration iConfig)
        {
            configuration = iConfig;
            _api = RestService.For<IApiGateway>(new HttpClient(new AuthenticatedHttpClientHandler(GetToken))
            {
                BaseAddress = new Uri(GetUrl()),
                Timeout = TimeSpan.FromSeconds(180)
            });
        }

        private async Task<string> GetToken()
        {
            return configuration.GetSection("AppSettings").GetSection("CryptoToken").Value;
        }

        private string GetUrl()
        {
            return configuration.GetSection("AppSettings").GetSection("CryptoAPI").Value;
        }

        public async Task<List<PatientModel>> FilterPatients(string bodyType, string bloodCode, string allergies, string gender, string smokingFrequency, string alcoholUnit, decimal alcoholValue,
                                                        decimal fitnessHours, string postCode, string nationality, string birthPlace, string toHospital)
        {
            try
            {
                var trxns = await _api.FilterPatients(bodyType, bloodCode, allergies, gender, smokingFrequency, alcoholUnit, alcoholValue, fitnessHours, postCode, nationality, birthPlace, toHospital);

                return trxns;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ConsultationModel>> FilterConsultations(string facility, string category, string department, string consOut, string remarks)
        {
            try
            {
                var trxns = await _api.FilterConsultations(facility, category, department, consOut, remarks);

                return trxns;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ConsultationModel>> GetAllConsultations()
        {
            try
            {
                var trxns = await _api.GetAllConsultations();

                return trxns;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<PrescriptionModel>> FilterPrescriptions(string drugName, string drugType, string dose, string frequency, string route, string des)
        {
            try
            {
                var trxns = await _api.FilterPrescriptions(drugName, drugType, dose, frequency, route, des);

                return trxns;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<int> TotalPatients()
        {
            try
            {
                var total = await _api.TotalPatients();

                return total;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public async Task<int> TotalTransactions()
        {
            try
            {
                var total = await _api.TotalTransactions();

                return total;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<int> TotalIssues()
        {
            try
            {
                var total = await _api.TotalIssues();

                return total;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<IssueModel>> FilterIssues(string type, string title)
        {
            try
            {
                var trxns = await _api.FilterIssues(type, title);

                return trxns;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<TransactionDetailModel<object>>> GetAllPatientTrxns(ExplorerRequestModel model)
        {
            try
            {
                var trxn = await _api.GetAllPatientTrxns(model);

                return trxn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
