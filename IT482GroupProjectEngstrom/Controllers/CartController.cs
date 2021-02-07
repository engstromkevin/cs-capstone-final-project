using IT482GroupProjectEngstrom.Models;
using IT482GroupProjectEngstrom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Controllers
{
    public class CartController : Controller
    {
        private ShoppingContext context { get; set; }
        private ShoppingCart cart { get; set; }

        public CartController(ShoppingContext ctx)
        {
            context = ctx;
            cart = new ShoppingCart(ctx);
        }

        public IActionResult CartIndex()
        {
            var viewModel = new ShoppingCartViewModel
            {
                cartContents = cart.GetCartContents(),
                cartTotal = cart.GetTotalPrice()
            };
            
            return View(cart);
        }

        public IActionResult AddToCart(string prodId, int quantity)
        {
            cart.AddToCart(prodId, quantity);

            // Now we dont need an AddToCart view!!
            return RedirectToAction("Index", "Home");
        }
        
        //[HttpPost]
        public IActionResult RemoveFromCart(string prodId, int quantity)
        {
            cart.RemoveFromCart(prodId, quantity);

            // Display the confirmation message
            /*var results = new ShoppingCartRemoveViewModel
            {
                message = "Item has been removed from your cart.",
                cartTotal = cart.GetTotalPrice(),
                cartCount = 2222,
                itemCount = 1111,
                deleteId = prodId
            };

            return View(results);*/

            return RedirectToAction("CartIndex", "Cart");
        }

        public IActionResult Checkout()
        {
            return View(cart);
        }

        public IActionResult NewSession()
        {
            cart.EmptyCart();

            return RedirectToAction("Index", "Home");
        }

        /* 
         [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
 
            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
        */

        /*
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }*/
    }
}
