using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLaborExchange.Models
{
    class Employer
    {
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public string IndustryType { get; set; }

        public Employer(string companyName)
        {
            CompanyName = companyName;
        }
    }
}
