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
        public string Position { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public string IndustryType { get; set; }
        public string PaymentConditions { get; set; }
        public string HousingConditions { get; set; }
        public string Requirements { get; set; }
        public DateTime PostDate { get; set; }

        public Advertisement(string companyName, string position)
        {
            CompanyName = companyName;
            Position = position;
            PostDate = DateTime.Now;
        }
    }
}