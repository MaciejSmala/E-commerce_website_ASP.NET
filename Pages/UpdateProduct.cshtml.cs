using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Pages
{
    public class UpdateProductModel : PageModel
    {
        public readonly AppDataContext _db;

        public UpdateProductModel(AppDataContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Product Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public void OnGet()
        {
            Products = _db.Products.Find(Id);
        }
        public IActionResult OnPost()
        {
            _db.Products.Update(Products);
            _db.SaveChanges();
            return RedirectToPage("/ManageProduce");
        }
    }
}
