using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreProductDetailDal: EfCoreGenericRepository<ProductDetail, DataContext>, IProductDetailDal
    {
    }
}
