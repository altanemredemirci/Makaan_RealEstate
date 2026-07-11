using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class ContactService : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactService(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public Contact GetOne()
        {
            return _contactDal.GetOne();
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
