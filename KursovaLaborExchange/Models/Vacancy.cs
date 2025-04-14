using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLaborExchange.Models
{
    class Vacancy
    {
        public string Position { get; set; }
        public string WorkingConditions { get; set; }
        public string PaymentConditions { get; set; }
        public string HousingConditions { get; set; }
        public string SpecialistRequirements { get; set; }
        public Employer Employer { get; set; }

        public Vacancy(string position, Employer employer)
        {
            Position = position;
            Employer = employer;
        }
    }
}
