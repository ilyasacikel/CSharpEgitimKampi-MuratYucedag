using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } // Class'ın adının sonuna Id getirirsek birincil anahtar ve otomatik artan olduğunu bildiriyoruz.
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } // Bir kategorinin birden fazla ürünü olabilir.

    }
}
