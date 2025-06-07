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
            // Create Employers
            Employer employer1 = new Employer("Tech Solutions Inc.")
            {
                ContactPerson = "Alice Johnson",
                ContactDetails = "alice.johnson@techsolutions.com",
                Address = "123 Silicon Ave, Kyiv",
                IndustryType = "Technology"
            };

            Employer employer2 = new Employer("HealthCare Corp.")
            {
                ContactPerson = "Bob Smith",
                ContactDetails = "bob.smith@healthcare.com",
                Address = "456 Medical Blvd, Kharkiv",
                IndustryType = "Healthcare"
            };

            Employer employer3 = new Employer("Banking Solutions")
            {
                ContactPerson = "John Doe",
                ContactDetails = "john.doe@banking.com",
                Address = "789 Finance St, Lviv",
                IndustryType = "Finance"
            };

            Employers.Add(employer1);
            Employers.Add(employer2);
            Employers.Add(employer3);

            // Create Vacancies
            Vacancy vacancy1 = new Vacancy("Software Developer", employer1)
            {
                WorkingConditions = "Full Time, On-Site",
                PaymentConditions = "$2000-3000",
                HousingConditions = "Not provided",
                SpecialistRequirements = "Bachelor's degree, JavaScript, C#"
            };

            Vacancy vacancy2 = new Vacancy("Nurse", employer2)
            {
                WorkingConditions = "Full Time, Shift Work",
                PaymentConditions = "$1200-1800",
                HousingConditions = "Dormitory available",
                SpecialistRequirements = "Nursing degree, registered nurse"
            };

            Vacancy vacancy3 = new Vacancy("Data Analyst", employer1)
            {
                WorkingConditions = "Full Time, Remote",
                PaymentConditions = "$1800-2500",
                HousingConditions = "Not applicable",
                SpecialistRequirements = "Master's degree, Python, SQL"
            };

            Vacancy vacancy4 = new Vacancy("Bank Teller", employer3)
            {
                WorkingConditions = "Full Time, On-Site",
                PaymentConditions = "$1000-1500",
                HousingConditions = "Not provided",
                SpecialistRequirements = "High school diploma, customer service experience"
            };

            Vacancies.Add(vacancy1);
            Vacancies.Add(vacancy2);
            Vacancies.Add(vacancy3);
            Vacancies.Add(vacancy4);

            // Create Candidates
            Candidate candidate1 = new Candidate("Vasya Petrenko", "Software Developer")
            {
                Education = "Bachelor's in Computer Science",
                LastEmployment = "Junior Developer at Rozetka",
                DismissalReason = "Company downsizing",
                MaritalStatus = "Single",
                HousingConditions = "Rented apartment",
                ContactDetails = "+380951111111",
                WorkRequirements = "Looking for growth opportunities"
            };

            Candidate candidate2 = new Candidate("Anastasia Kovalenko", "Nurse")
            {
                Education = "Nursing Diploma",
                LastEmployment = "Assistant Nurse at local Hospital",
                DismissalReason = "Career advancement",
                MaritalStatus = "Married",
                HousingConditions = "Owned house",
                ContactDetails = "anastasiaukraine@gmail.com",
                WorkRequirements = "Flexible working hours"
            };

            Candidate candidate3 = new Candidate("Igor Shevchenko", "Data Analyst")
            {
                Education = "Master's in Statistics",
                LastEmployment = "Analyst at Marketing Agency",
                DismissalReason = "End of contract",
                MaritalStatus = "Single",
                HousingConditions = "Lives with parents",
                ContactDetails = "+380672222222",
                WorkRequirements = "Remote work preferred"
            };

            Candidates.Add(candidate1);
            Candidates.Add(candidate2);
            Candidates.Add(candidate3);
        }

        // Search methods for vacancies
        public List<Vacancy> SearchVacancies(string jobTitle = null, string location = null,
            string education = null, string paymentRange = null, string housing = null)
        {
            var filteredVacancies = Vacancies.AsEnumerable();

            // Filter by job title
            if (!string.IsNullOrWhiteSpace(jobTitle))
            {
                filteredVacancies = filteredVacancies.Where(v =>
                    v.Position.ToLower().Contains(jobTitle.ToLower()));
            }

            // Filter by location (search in employer's address)
            if (!string.IsNullOrWhiteSpace(location))
            {
                filteredVacancies = filteredVacancies.Where(v =>
                    v.Employer.Address.ToLower().Contains(location.ToLower()));
            }

            // Filter by education requirements
            if (!string.IsNullOrWhiteSpace(education) && education != "All")
            {
                filteredVacancies = filteredVacancies.Where(v =>
                    v.SpecialistRequirements.ToLower().Contains(education.ToLower()));
            }

            // Filter by payment range
            if (!string.IsNullOrWhiteSpace(paymentRange) && paymentRange != "All")
            {
                filteredVacancies = filteredVacancies.Where(v =>
                    FilterByPaymentRange(v.PaymentConditions, paymentRange));
            }

            // Filter by housing
            if (!string.IsNullOrWhiteSpace(housing) && housing != "All")
            {
                if (housing == "Provided")
                {
                    filteredVacancies = filteredVacancies.Where(v =>
                        !v.HousingConditions.ToLower().Contains("not") &&
                        !v.HousingConditions.ToLower().Contains("n/a"));
                }
                else if (housing == "Not Provided")
                {
                    filteredVacancies = filteredVacancies.Where(v =>
                        v.HousingConditions.ToLower().Contains("not") ||
                        v.HousingConditions.ToLower().Contains("n/a"));
                }
            }

            return filteredVacancies.ToList();
        }

        // Search methods for candidates
        public List<Candidate> SearchCandidates(string profession = null, string education = null,
            string maritalStatus = null, string housing = null)
        {
            var filteredCandidates = Candidates.AsEnumerable();

            // Filter by profession
            if (!string.IsNullOrWhiteSpace(profession))
            {
                filteredCandidates = filteredCandidates.Where(c =>
                    c.Profession.ToLower().Contains(profession.ToLower()));
            }

            // Filter by education
            if (!string.IsNullOrWhiteSpace(education) && education != "All")
            {
                filteredCandidates = filteredCandidates.Where(c =>
                    c.Education.ToLower().Contains(education.ToLower()));
            }

            // Filter by marital status
            if (!string.IsNullOrWhiteSpace(maritalStatus) && maritalStatus != "All")
            {
                filteredCandidates = filteredCandidates.Where(c =>
                    c.MaritalStatus.ToLower() == maritalStatus.ToLower());
            }

            // Filter by housing conditions
            if (!string.IsNullOrWhiteSpace(housing) && housing != "All")
            {
                filteredCandidates = filteredCandidates.Where(c =>
                    c.HousingConditions.ToLower().Contains(housing.ToLower()));
            }

            return filteredCandidates.ToList();
        }

        private bool FilterByPaymentRange(string paymentConditions, string selectedRange)
        {
            // Extract numbers from payment conditions
            var numbers = System.Text.RegularExpressions.Regex.Matches(paymentConditions, @"\d+")
                .Cast<System.Text.RegularExpressions.Match>()
                .Select(m => int.Parse(m.Value))
                .ToList();

            if (!numbers.Any()) return false;

            int maxSalary = numbers.Max();

            switch (selectedRange)
            {
                case "Under $1500":
                    return maxSalary < 1500;
                case "$1500-2000":
                    return maxSalary >= 1500 && maxSalary <= 2000;
                case "$2000-3000":
                    return maxSalary >= 2000 && maxSalary <= 3000;
                case "Above $3000":
                    return maxSalary > 3000;
                default:
                    return true;
            }
        }

        // Registration methods
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

        // Get all data methods
        public List<Vacancy> GetAllVacancies()
        {
            return Vacancies.ToList();
        }

        public List<Candidate> GetAllCandidates()
        {
            return Candidates.ToList();
        }
    }
}