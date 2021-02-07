using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string message { get; set; }
        public decimal cartTotal { get; set; }
        public int cartCount { get; set; }
        public int itemCount { get; set; }
        public string deleteId { get; set; }
    }
}
