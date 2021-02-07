using IT482GroupProjectEngstrom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<LineItem> cartContents { get; set; }
        public decimal cartTotal { get; set; }
    }
}
