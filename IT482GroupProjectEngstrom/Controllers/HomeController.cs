using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using IT482GroupProjectEngstrom.Models;

namespace IT482GroupProjectEngstrom.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private ShoppingContext context { get; set; }
        private List<LineItem> cart { get; set; }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(ShoppingContext ctx)
        {
            context = ctx;
            cart = new List<LineItem>();
        }

        public IActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var products = context.Product.Where(p => p.ProductName.Contains(searchString)).Include(p => p.Category).OrderBy(p => p.ProductName).ToList();
                return View(products);
            }
            else {
                var products = context.Product.Include(p => p.Category).OrderBy(p => p.ProductName).ToList();
                return View(products);
            }
        }
           
        public IActionResult Cart(string id)
        {
            Debug.WriteLine("I got here");
            // These values end up null - can only use Request.Form in HttpPost, but
            // method="post" is not allowed in <a>, but an input submit cant pass
            // along p /and/ be accessible by Request.Form, it only has one id/name
            string prodId = Request.Query[id+"prodId"].ToString();
            int quantity = Int32.Parse(Request.Query[id+"quantity"]);

            return View(cart);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
