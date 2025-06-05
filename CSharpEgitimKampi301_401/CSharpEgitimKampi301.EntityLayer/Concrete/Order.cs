﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; } // Hangi ürünü sattığımı bilmeliyim.
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; } // Ürün kime satıldı?
        public virtual Customer Customer { get; set; } // Müşterinin diğer bilgilerine ulaşmak için

    }
}
