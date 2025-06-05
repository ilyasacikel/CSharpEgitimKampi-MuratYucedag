using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    // Bir sınıfı tablo olarak veri tabanına yansıtmak istiyorsak bu sınıfın içinde yapmalıyız.
    public class KampContext : DbContext  
    {
        public DbSet<Category> Categories { get; set; }
        // <...> içindeki class C# tarafında kullanacığımız sınıfın ismi.
        // çoğul hali ise SQL tarafına yansıyacak olan tablo ismi
        // sınıf ve tablo birbirinin içine girmesin diye, birbirinden ayırt edilsin diye yalın hali C# tarafında çoğul hali SQL de kullanılır.
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
