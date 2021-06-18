using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Pages
{
    [Authorize(Roles = "Admin")]
    public class AddProductsModel : PageModel
    {

        public readonly AppDataContext _db;

        public AddProductsModel(AppDataContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(Product);
            _db.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
