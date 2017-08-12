using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductDemo.Data.Model;
using ProductDemo.Data.DataContext;
using System.Data.Entity.Migrations;


namespace ProductDemo.Core.Repository
{

    public class ProductFeatureRepository : IProductFeatureRepository
    {
        private readonly ProductDemoContext _context = new ProductDemoContext();
       

        public Data.Model.ProductFeature Get(System.Linq.Expressions.Expression<Func<Data.Model.ProductFeature, bool>> expression)
        {
            return _context.ProductFeature.FirstOrDefault(expression);
        }

        public IEnumerable<Data.Model.ProductFeature> GetAll()
        {
            return _context.ProductFeature.Select(x => x);
        }

        public Data.Model.ProductFeature GetById(int id)
        {
            return _context.ProductFeature.FirstOrDefault(x => x.ProductFeatureId == id);
        }

        public IQueryable<Data.Model.ProductFeature> GetMany(System.Linq.Expressions.Expression<Func<Data.Model.ProductFeature, bool>> expression)
        {
            return _context.ProductFeature.Where(expression);
        }

        public void Insert(Data.Model.ProductFeature obj)
        {
            _context.ProductFeature.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductFeature obj)
        {
            _context.ProductFeature.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.ProductFeature.Count();
        }

        public void Delete(int id)
        {
            var productFeature = GetById(id);
            if (productFeature != null)
            {
                _context.ProductFeature.Remove(productFeature);
            }
        }
    }
}
