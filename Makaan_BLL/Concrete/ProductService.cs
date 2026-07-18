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
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }      

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _productDal.GetAll(filter);
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public Product GetOne(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetOne(filter);
        }

        public List<Product> GetPopularAll()
        {
            return _productDal.GetPopularAll();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
