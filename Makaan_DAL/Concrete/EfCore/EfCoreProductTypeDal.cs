using Makaan_DAL.Abstract;
using Makaan_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreProductTypeDal:EfCoreGenericRepository<ProductType,DataContext>,IProductTypeDal
    {
        public override List<ProductType> GetAll(Expression<Func<ProductType, bool>> filter)
        {
            using(var context = new DataContext())
            {
                var productTypes = context.ProductTypes.Include(i => i.Products).AsNoTracking().AsQueryable();

                if(filter!= null)
                {
                    productTypes = productTypes.Where(filter);
                }

                return productTypes.ToList();
            }
        }
    }
}
