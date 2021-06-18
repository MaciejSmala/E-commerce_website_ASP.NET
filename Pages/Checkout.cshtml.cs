using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<CartItem> cart { get; set; }
        public void OnGet(List<CartItem> Cart){
            cart = Cart;
        }
    }
}
