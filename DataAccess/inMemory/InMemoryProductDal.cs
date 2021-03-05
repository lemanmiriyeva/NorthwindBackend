using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.inMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Bardak",UnitPrice = 5,UnitsInStock = 5},
                new Product{ProductId = 2,CategoryId = 2,ProductName = "Telefon",UnitPrice = 5,UnitsInStock = 5},
                new Product{ProductId = 3,CategoryId = 3,ProductName = "Kamera",UnitPrice = 5,UnitsInStock = 5}
            };
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Update(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryId = entity.CategoryId;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
        }

        public void Delete(Product entity)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            _products.Remove(productToDelete);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
