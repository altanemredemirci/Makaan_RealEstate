using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreSliderDal : ISliderDal
    {
        public Slider GetAll(Expression<Func<Slider, bool>> filter)
        {
            using(var context = new DataContext())
            {
                return context.Sliders.FirstOrDefault(filter);
            }
        }
    }
}
