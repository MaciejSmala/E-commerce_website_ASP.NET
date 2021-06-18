using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDataContext _context;
        private ProductRepository _productRepository;

        public ProductsController(AppDataContext context, ProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }
        public string Index()
        {
            return _productRepository.GetProduct("5").Name;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public IEnumerable<Product> Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _context.Products.ToList();
            }
            return _context.Products.ToList().Where(e => e.Name.Contains(searchTerm) || e.Description.Contains(searchTerm));
            // GET: Products
            /*
            public async Task<IActionResult> Index()
            {
                return View(await _context.Products.ToListAsync());
            }
            */
        }
    }
}