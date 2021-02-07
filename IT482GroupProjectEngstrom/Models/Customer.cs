using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string AddressLine01 { get; set; }

        public string AddressLine02 { get; set; }

        public string AddressLine03 { get; set; }

        public string CreditCardNumber { get; set; }

        public DateTime DOB { get; set; }
    }
}
