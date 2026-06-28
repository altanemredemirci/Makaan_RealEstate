using Makaan_DAL.Abstract;
using Makaan_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, DataContext>, IProductDal
    {
        public List<Product> GetPopularAll()
        {
            using (var context = new DataContext())
            {
                return context.Products.Where(i => i.IsPopular == true && i.Status == true).Include(i => i.ProductType).Include(i => i.City).ToList();
            }
        }
    }
}
