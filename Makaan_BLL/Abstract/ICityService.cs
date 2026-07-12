using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        List<District> GetDistrictById(int id);
    }
}
