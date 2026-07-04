using Makaan_DAL.Abstract;
using Makaan_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreWhoWeAreDal : IWhoWeAreDal
    {
        public WhoWeAre GetOne()
        {
            using(var context = new DataContext())
            {
                return context.WhoWeAres.Include(i => i.Employments.Where(i => i.Status)).FirstOrDefault();
            };
        }

        public void Update(WhoWeAre entity)
        {
           using(var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
