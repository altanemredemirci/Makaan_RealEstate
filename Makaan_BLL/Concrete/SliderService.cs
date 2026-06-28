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
        public void Create(Slider entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Slider entity)
        {
            throw new NotImplementedException();
        }

        public List<Slider> GetAll(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(filter);
        }

        public Slider GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}
