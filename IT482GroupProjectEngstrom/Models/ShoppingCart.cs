using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IT482GroupProjectEngstrom.Models
{
    public class ShoppingCart
    {
        private ShoppingContext context { get; set; }
        private List<LineItem> cart { get; set; }
        private Invoice invoice { get; set; }

        public ShoppingCart(ShoppingContext ctx)
        {
            context = ctx;
            cart = new List<LineItem>();
            invoice = new Invoice();

            // globally unique identifier
            invoice.InvoiceNum = Guid.NewGuid().ToString().Substring(0, 10);
        }

        public static ShoppingCart GetCart(ShoppingContext context)
        {
            var shopCart = new ShoppingCart(context);
            //cart.ShoppingCartId = cart.GetCartId(context);
            return shopCart;
        }

        // Helper method to simplify shopping cart calls
        /*public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }*/

        public void AddToCart(string prodId, int quantity)
        {
            if (!String.IsNullOrEmpty(prodId))
            {
                Product prod = context.Product.Find(prodId);
                LineItem duplicate = context.Cart.SingleOrDefault(l => l.ProductID.Equals(prodId));
                                        //&& l.InvoiceNum.Equals(invoice.InvoiceNum));
                
                if(duplicate == null)
                {
                    Debug.WriteLine(prodId + " is not a duplicate");
                    if (prod.Quantity >= quantity)
                    {
                        var lineItem = new LineItem
                        {
                            ProductID = prodId,
                            InvoiceNum = invoice.InvoiceNum,
                            Quantity = quantity,
                            Price = quantity * prod.Price
                        };

                        context.Cart.Add(lineItem);
                        //cart.Add(lineItem);
                    }
                }
                else
                {
                    Debug.WriteLine(prodId + " is a duplicate");
                    quantity += duplicate.Quantity;

                    if (prod.Quantity >= quantity)
                    {
                        duplicate.Quantity = quantity;
                        duplicate.Price = quantity * prod.Price;
                    }
                }

                context.SaveChanges();
            }
        }

        public void RemoveFromCart(string prodId, int quantity)
        {
            if (!String.IsNullOrEmpty(prodId))
            {
                Product prod = context.Product.Find(prodId);
                LineItem item = context.Cart.SingleOrDefault(l => l.ProductID.Equals(prodId));
                                    //&& l.InvoiceNum.Equals(invoice.InvoiceNum));

                if (item != null)
                {
                    if (quantity >= item.Quantity)
                    {
                        context.Cart.Remove(item);
                    }
                    else
                    {
                        item.Quantity -= quantity;
                        item.Price -= quantity * prod.Price;
                    }
                }

                context.SaveChanges();
            }
        }

        public void EmptyCart()
        {
            var cartItems = context.Cart; //.Where(l => l.InvoiceNum.Equals(invoice.InvoiceNum));

            foreach (var cartItem in cartItems)
            {
                context.Cart.Remove(cartItem);
            }
            
            context.SaveChanges();
        }

        public List<LineItem> GetCartContents()
        {
            return context.Cart.ToList(); //.Where(l => l.InvoiceNum.Equals(invoice.InvoiceNum)).ToList();
        }

        //public int GetTotalCount()

        public decimal GetTotalPrice()
        {
            decimal total = 0m;

            var cartItems = context.Cart; //.Where(l => l.InvoiceNum.Equals(invoice.InvoiceNum));
            foreach (var cartItem in cartItems)
            {
                total += cartItem.Price;
            }

            return total;
        }

        public Invoice GetInvoice()
        {
            return invoice;
        }

        public ShoppingContext GetContext()
        {
            return context;
        }

        //public int CreateInvoice()
    }
}
