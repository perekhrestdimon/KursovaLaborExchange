using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLaborExchange.Models
{
    class LaborExchangeFacade
    {
        public List<Candidate> Candidates { get; private set; }
        public List<Vacancy> Vacancies { get; private set; }
        public List<Employer> Employers { get; private set; }

        public LaborExchangeFacade()
        {
            Candidates = new List<Candidate>();
            Vacancies = new List<Vacancy>();
            Employers = new List<Employer>();

            
            CreateTestData();
        }

        
        private void CreateTestData()
        {
            
            Employer employer1 = new Employer("Tech Solutions Inc.")
            {
                ContactPerson = "Alice Johnson",
                ContactDetails = "alice.johnson@techsolutions.com",
                Address = "123 Silicon Ave",
                IndustryType = "Technology"
            };

            Employer employer2 = new Employer("HealthCare Corp.")
            {
                ContactPerson = "Bob Smith",
                ContactDetails = "bob.smith@healthcare.com",
                Address = "456 Medical Blvd",
                IndustryType = "Healthcare"
            };

            Employers.Add(employer1);
            Employers.Add(employer2);

            
            Vacancy vacancy1 = new Vacancy("Software Developer", employer1)
            {
                WorkingConditions = "Full Time, On-Site",
                PaymentConditions = "Competitive salary + benefits",
                HousingConditions = "N/A",
                SpecialistRequirements = "JavaScript"
            };

            Vacancy vacancy2 = new Vacancy("Nurse", employer2)
            {
                WorkingConditions = "Full Time, Shift Work",
                PaymentConditions = "Hourly rate + overtime",
                HousingConditions = "N/A",
                SpecialistRequirements = "Nursing degree, registered nurse"
            };

            Vacancies.Add(vacancy1);
            Vacancies.Add(vacancy2);

            // Create Candidates
            Candidate candidate1 = new Candidate("Vasya Vasya", "Software Developer")
            {
                Education = "B.Sc. in Computer Science",
                LastEmployment = "Junior Developer at Rozetka",
                DismissalReason = "Company downsizing",
                MaritalStatus = "Single",
                HousingConditions = "Rented apartment",
                ContactDetails = "+3809511111",
                WorkRequirements = "Looking for growth opportunities"
            };

            Candidate candidate2 = new Candidate("Anastasia Ukraine", "Nurse")
            {
                Education = "Nursing Diploma",
                LastEmployment = "Assistant Nurse at local Hospital",
                DismissalReason = "Career change",
                MaritalStatus = "Married",
                HousingConditions = "Owned house",
                ContactDetails = "anastasiaukraine@gmail.com",
                WorkRequirements = "Flexible working hours"
            };

            Candidates.Add(candidate1);
            Candidates.Add(candidate2);
        }

        
        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public void RegisterVacancy(Vacancy vacancy)
        {
            Vacancies.Add(vacancy);
        }

        public void RegisterEmployer(Employer employer)
        {
            Employers.Add(employer);
        }
    }
}
