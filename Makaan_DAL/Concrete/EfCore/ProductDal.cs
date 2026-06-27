using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class ProductDal : IProductDal
    {
        DataContext db = new DataContext();

        public void Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            db.Products.Remove(entity);
            db.SaveChanges();
        }

        public List<Product> GetAll()
        {
           return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Product entity)
        {
            db.SaveChanges();
        }
    }
}
