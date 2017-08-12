using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductDemo.Data.DataContext;
using System.Data.Entity.Migrations;

namespace ProductDemo.Core.Repository
{
    public class ProductImageRepository : IProductImageRepository
    {

        private readonly ProductDemoContext _context = new ProductDemoContext();
        public Data.Model.ProductImage Get(System.Linq.Expressions.Expression<Func<Data.Model.ProductImage, bool>> expression)
        {
            return _context.ProductImage.FirstOrDefault(expression);
        }

        public IEnumerable<Data.Model.ProductImage> GetAll()
        {
            return _context.ProductImage.Select(x => x);
        }

        public Data.Model.ProductImage GetById(int id)
        {
            return _context.ProductImage.FirstOrDefault(x=>x.ProductImageId==id);
        }

        public IQueryable<Data.Model.ProductImage> GetMany(System.Linq.Expressions.Expression<Func<Data.Model.ProductImage, bool>> expression)
        {
            return _context.ProductImage.Where(expression);
        }

        public void Insert(Data.Model.ProductImage obj)
        {
            _context.ProductImage.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Data.Model.ProductImage obj)
        {
            _context.ProductImage.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.Category.Count();
        }

        public void Delete(int id)
        {
            var productImage = GetById(id);
            if (productImage != null)
            {
                _context.ProductImage.Remove(productImage);
            }
        }
    }
}
