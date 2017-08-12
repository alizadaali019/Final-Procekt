using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductDemo.Data.Model;
using System.Linq.Expressions;
using ProductDemo.Data.DataContext;
using System.Data.Entity.Migrations;

namespace ProductDemo.Core.Repository
{
    public class ProductReposiyory : IProductRepository
    {

        private readonly ProductDemoContext _context = new ProductDemoContext();
        public Product Get(Expression<Func<Product, bool>> expression)
        {
            return _context.Product.FirstOrDefault(expression);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.Select(x => x);
        }

        public Product GetById(int id)
        {
            return _context.Product.FirstOrDefault(x => x.ProductId == id);
        }

        public IQueryable<Product> GetMany(Expression<Func<Product, bool>> expression)
        {
            return _context.Product.Where(expression);
        }

        public void Insert(Product obj)
        {
            _context.Product.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product obj)
        {
            _context.Product.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.Product.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Product.Remove(product);
            }
        }
    }
}
