using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Abstract
{
    public interface ICityDal
    {
        List<City> GetAll();
        List<District> GetDistrictById(int id);
    }
}
