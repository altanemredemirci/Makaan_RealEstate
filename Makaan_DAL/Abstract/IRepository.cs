using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Abstract
{
    public interface IRepository<T> where T:class
    {
        List<T> GetAll();
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
