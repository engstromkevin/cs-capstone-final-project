using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class Product
    {
        [Key]
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Brand { get; set; }

        public string ProductDescr { get; set; }

        public string CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
