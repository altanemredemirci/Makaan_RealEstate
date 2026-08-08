using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface ISliderService
    {
        List<Slider> GetAll(Expression<Func<Slider, bool>> filter = null);
        Slider GetOne(Expression<Func<Slider, bool>> filter = null);

        void Update(Slider entity);
    }
}
