using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N0855975_assessment2.Models
{
    public class AppDataContext : IdentityDbContext<AppUser>
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) :
        base(options)
        { }
        public DbSet<Product> Products { get; set; }
        //IEnumerable<Product> Search(string searchTerm);

    }
    public interface ProductRepository {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(string id);
        IEnumerable<Product> Search(string searchTerm);
    }

}
