using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x => new
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();
        }

        public List<object> GetProductsWithCategory(int id)
        {
            var context = new KampContext();
            var values = context.Products.Where(x=> x.ProductId==id).Select(y=> new
            {
                ProductId = y.ProductId,
                ProductName = y.ProductName,
                ProductStock = y.ProductStock,
                ProductPrice = y.ProductPrice,
                ProductDescription = y.ProductDescription,
                CategoryName = y.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();

        }
    }
}
