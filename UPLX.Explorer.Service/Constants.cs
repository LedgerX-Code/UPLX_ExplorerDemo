using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLX.Explorer.Service
{
    public static class Constants
    {
        public const string Patient = "Patient";
        public const string Consultation = "Consultation";
        public const string Prescription = "Prescription";
        public const string Issue = "Issue";

        //Shouldn't add more const into the current structs. Must create a new struct
        public struct PatientConstant
        {
            public const string BodyType = "Body Type";
            public const string bodyType = "bodyType";
            public const string BloodCode = "Blood Code";
            public const string bloodCode = "bloodCode";
            public const string Allergies = "Allergies";
            public const string allergies = "allergies";
            public const string Gender = "Gender";
            public const string gender = "gender";
            public const string SmokingFrequency = "Smoking Frequency";
            public const string smokingFrequency = "smokingFrequency";
            public const string WeeklyFitnessHours = "Weekly Fitness Hours";
            public const string weeklyFitnessHours = "weeklyFitnessHours";
            public const string PostalCode = "Postal Code";
            public const string postCode = "postCode";
            public const string Nationality = "Nationality";
            public const string nationality = "nationality";
            public const string AccessibilityToHospital = "Accessibility To Hospital";
            public const string accessibilityToHospital = "accessibilityToHospital";
            public const string WeeklyAlcoholConsumption = "Weekly Alcohol Consumption";
            public const string alcoholUnit = "alcoholUnit";
            public const string alcoholValue = "alcoholValue";
            public const string BirthPlace = "Birth Place";
            public const string birthPlace = "birthPlace";
        }

        public struct ConsultationConstant
        {
            public const string Facility = "Facility";
            public const string facility = "facility";
            public const string OrgCountry = "Organization Country";
            public const string orgCountry = "orgCountry";
            public const string ConsultedDate = "Consulted Date";
            public const string consultedDate = "consultedDate";
            public const string Category = "Category";
            public const string category = "category";
            public const string Department = "Department";
            public const string department = "department";
            public const string Remarks = "Remarks";
            public const string remarks = "remarks";
            public const string ConsOutcome = "ConsOutcome";
            public const string consOutcome = "consOutcome";
        }

        public struct PrescriptionConstant
        {
            public const string DrugName = "Drug Name";
            public const string drugName = "drugName";
            public const string DrugType = "Drug Type";
            public const string drugType = "drugType";
            public const string Dose = "Dosage";
            public const string dose = "dose";
            public const string Route = "Route";
            public const string route = "route";
            public const string Frequency = "Frequency";
            public const string frequency = "frequency";
            public const string Description = "Description";
            public const string description = "description";
        }

        public struct IssueConstant
        {
            public const string IssueType = "Issue Type";
            public const string issueType = "type";
            public const string IssueTitle = "Issue Title";
            public const string issueTitle = "title";
        }
    }
}
