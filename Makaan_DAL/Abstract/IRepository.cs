using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_DAL.Abstract
{
    public interface IRepository<T> where T:class
    {
        List<T> GetAll(Expression<Func<T,bool>> filter);
        T GetOne(Expression<Func<T,bool>> filter);
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
