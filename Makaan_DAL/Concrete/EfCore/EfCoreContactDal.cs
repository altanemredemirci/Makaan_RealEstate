using Makaan_DAL.Abstract;
using Makaan_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Concrete.EfCore
{
    public class EfCoreContactDal : IContactDal
    {
        public Contact GetOne()
        {
            using(var context = new DataContext())
            {
                return context.Contacts.FirstOrDefault();
            }
        }

        public void Update(Contact entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
