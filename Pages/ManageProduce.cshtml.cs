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
    public class ManageProduceModel : PageModel
    {
        private readonly AppDataContext _db;

        public ManageProduceModel(AppDataContext db)
        {

            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public List<Product> products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public void OnGet()
        {
            products = _db.Products.ToList();

        }
        public IActionResult OnGetDelete()
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("/ManageProduce");
        }
    }
}
