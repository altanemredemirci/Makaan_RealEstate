using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface IProductService:IRepositoryService<Product>
    {
        List<Product> GetPopularAll();
    }
}
