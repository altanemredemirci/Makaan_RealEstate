using Makaan_DAL.Abstract;
using Makaan_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreCityDal : ICityDal
    {
        public List<City> GetAll()
        {
            using(var context = new DataContext())
            {
                return context.Cities.Include(i => i.Districts).ToList();
            }
        }

        public List<District> GetDistrictById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Districts.Where(i=> i.CityId==id).ToList();
            }
        }
    }
}
