using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using N0855975_assessment2.Models;
namespace N0855975_assessment2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       //private readonly ProductRepository _productRepository;
        public readonly AppDataContext _db;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Product> products { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger, AppDataContext db)
       {
           _logger = logger;
           _db = db;
           //_productRepository = productRepository;
       }

        public void OnGet()
        {
            //products = _db.Products.ToList();
            if (string.IsNullOrEmpty(searchTerm))
            {
                products= _db.Products.ToList();
            }
            else {
                products = _db.Products.Where(e => e.Name.Contains(searchTerm) || e.Description.Contains(searchTerm));
            }
        }
    }
}
