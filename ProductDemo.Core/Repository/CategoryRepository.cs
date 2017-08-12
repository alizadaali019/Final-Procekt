using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductDemo.Data.DataContext;
using System.Data.Entity.Migrations;

namespace ProductDemo.Core.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductDemoContext _context = new ProductDemoContext();


        public int Count()
        {
           
            return _context.Category.Count();
        }

        public void Delete(int id)
        {
            var catagory = GetById(id);
            if(catagory!=null)
            {
                _context.Category.Remove(catagory);
            }
        }

        public Data.Model.Category Get(System.Linq.Expressions.Expression<Func<Data.Model.Category, bool>> expression)
        {
            return _context.Category.FirstOrDefault(expression);
        }

        public IEnumerable<Data.Model.Category> GetAll()
        {
            return _context.Category.Select(x => x);
        }

        public Data.Model.Category GetById(int id)
        {
            return _context.Category.FirstOrDefault(x => x.CategoryId == id);
        }

        public IQueryable<Data.Model.Category> GetMany(System.Linq.Expressions.Expression<Func<Data.Model.Category, bool>> expression)
        {
            return _context.Category.Where(expression);
        }

        public void Insert(Data.Model.Category obj)
        {
            _context.Category.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Data.Model.Category obj)
        {
            _context.Category.AddOrUpdate(obj);
        }

        
    }
}
