using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLaborExchange.Models
{
    class Advertisement
    {
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public string IndustryType { get; set; }

        // Fix for CS0106: Removed the invalid 'required' modifier.
        // Fix for IDE0290: Converted to a primary constructor.
        public Advertisement(string companyName, string contactPerson, string contactDetails, string address, string industryType)
        {
            CompanyName = companyName;
            ContactPerson = contactPerson;
            ContactDetails = contactDetails;
            Address = address;
            IndustryType = industryType;
        }
    }
}
