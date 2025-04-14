using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLaborExchange.Models
{
    class Candidate
    {
        public string PersonalData { get; set; }
        public string Profession { get; set; }
        public string Education { get; set; }
        public string LastEmployment { get; set; }
        public string DismissalReason { get; set; }
        public string MaritalStatus { get; set; }
        public string HousingConditions { get; set; }
        public string ContactDetails { get; set; }
        public string WorkRequirements { get; set; }

        public Candidate(string personalData, string profession)
        {
            PersonalData = personalData;
            Profession = profession;
        }
    }
}
