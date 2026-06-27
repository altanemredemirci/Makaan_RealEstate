using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface IRepositoryService<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //i=> i.id>5
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
