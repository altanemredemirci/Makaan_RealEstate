using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IProductDetailDal _productDetailDal;

        public ProductDetailService(IProductDetailDal productDetailDal)
        {
            _productDetailDal = productDetailDal;
        }
        public void Create(ProductDetail entity)
        {
            _productDetailDal.Create(entity);
        }

        public void Delete(ProductDetail entity)
        {
            _productDetailDal.Delete(entity);
        }

        public List<ProductDetail> GetAll(Expression<Func<ProductDetail, bool>> filter = null)
        {
            return _productDetailDal.GetAll(filter);
        }

        public ProductDetail GetById(int id)
        {
            return _productDetailDal.GetById(id);
        }

        public ProductDetail GetOne(Expression<Func<ProductDetail, bool>> filter = null)
        {
             return _productDetailDal.GetOne(filter);
        }

        public void Update(ProductDetail entity)
        {
            _productDetailDal.Update(entity);
        }
    }
}
