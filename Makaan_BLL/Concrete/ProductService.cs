using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }      

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _productDal.GetAll(filter);
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
