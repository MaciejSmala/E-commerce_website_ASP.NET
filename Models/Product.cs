using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N0855975_assessment2.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public string ProductImage { get; set; }
    }
    
    
}
