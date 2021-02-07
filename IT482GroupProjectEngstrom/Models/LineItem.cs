using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class LineItem
    {
        [Key]
        public string ProductID { get; set; }
        
        public string InvoiceNum { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
