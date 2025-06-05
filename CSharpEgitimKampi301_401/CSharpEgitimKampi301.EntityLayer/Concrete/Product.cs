using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; } // Her ürünün bir kategori id'si vardır.
        // Üründen CategoryName e gitmemiz gerekebilir.
        // Context.Product.Category.CategoryName
        // Bu işlemden Category sınıfımızı haberdar etmemiz lazım.
        public virtual Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
