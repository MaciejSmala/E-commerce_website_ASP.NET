using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using N0855975_assessment2.Helpers;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Pages
{
    
    public class CartModel : PageModel
    {
        public readonly AppDataContext _db;

        public CartModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<CartItem> cart { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string Summary { get; set; }
        [BindProperty]
        public Product product { get; set; }
        public void OnGet() {

            if (!cart.Any()) {
                cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart"); 
           }
        }
        public void OnGetBuyNow()
        {
            cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
                cart.Add(new CartItem
                {
                    Product = _db.Products.Find(Id),
                    Quantity = 1
                });
                SessionHelper.Set(HttpContext.Session, "cart", cart);

            }
            else
            {
                int i = Exists(cart);
                if (i == -1)
                {
                    cart.Add(new CartItem
                    {
                        Product = _db.Products.Find(Id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[i].Quantity++;
                }
                    SessionHelper.Set(HttpContext.Session, "cart", cart);
            }

        }
        private int Exists(List<CartItem> cart)
        {
            for (var i = 0; i < cart.Count; i++) {
                if (cart[i].Product.Id == Id) {
                    return i;
                }
            }
            return -1;
        }
        public void OnGetDelete() {
            cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            int i = Exists(cart);
            cart.RemoveAt(i);
            SessionHelper.Set(HttpContext.Session, "cart", cart);
        }

        
    }
}
