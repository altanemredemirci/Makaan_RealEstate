using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class CityService : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public List<District> GetDistrictById(int id)
        {
            return _cityDal.GetDistrictById(id);
        }
    }
}
