using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_DAL.Abstract
{
    public interface ISliderDal
    {
        List<Slider> GetAll(Expression<Func<Slider, bool>> filter);
        Slider GetOne(Expression<Func<Slider, bool>> filter);
        void Update(Slider entity);
        void Create(Slider entity);
    }
}
