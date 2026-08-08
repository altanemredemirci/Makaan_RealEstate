using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class SliderService : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderService(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public Slider GetOne(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetOne(filter);
        }

        public void Update(Slider entity)
        {
            _sliderDal.Update(entity);
        }

        public List<Slider> GetAll(Expression<Func<Slider, bool>> filter)
        {
            return _sliderDal.GetAll(filter);
        }

        public void Create(Slider entity)
        {
            _sliderDal.Create(entity);
        }
    }
}
