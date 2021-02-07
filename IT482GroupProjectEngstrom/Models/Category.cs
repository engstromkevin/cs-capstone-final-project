using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class Category
    {
        [Key]
        public string CatCode { get; set; }

        public string CatDescription { get; set; }
    }
}
