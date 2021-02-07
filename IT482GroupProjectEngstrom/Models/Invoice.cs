using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class Invoice
    {
        [Key]
        public string InvoiceNum { get; set; }

        public string CustomerID { get; set; }
    }
}
