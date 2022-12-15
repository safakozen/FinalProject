using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDAL : IProductDAL
    {
        List<Product> _products;
        public InMemoryProductDAL()
        {
            _products = new List<Product> {
            new Product{ProductId =1, ProductName ="Bardak",CategoryId=1,UnitsInstock=15, UnitPrice=15},
            new Product{ProductId =2, ProductName ="kamera",CategoryId=1,UnitsInstock=3, UnitPrice=500},
            new Product{ProductId =3, ProductName ="Telefon",CategoryId=2,UnitsInstock=2, UnitPrice=1500},
            new Product{ProductId =4, ProductName ="Klavye",CategoryId=2,UnitsInstock=65, UnitPrice=150},
            new Product{ProductId =5, ProductName ="Mouse",CategoryId=2,UnitsInstock=1, UnitPrice=85},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
            //foreach (var item in _products)
            //{
            //    if (item.ProductId == product.ProductId)
            //    {
            //        productToDelete = item;
            //    }


            //}

            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
