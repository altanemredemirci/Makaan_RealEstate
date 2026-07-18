using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyDal _agencyDal;

        public AgencyService(IAgencyDal agencyDal)
        {
            _agencyDal = agencyDal;
        }
        public void Create(Agency entity)
        {
            _agencyDal.Create(entity);
        }

        public void Delete(Agency entity)
        {
            _agencyDal.Delete(entity);
        }

        public List<Agency> GetAll(Expression<Func<Agency, bool>> filter = null)
        {
            return _agencyDal.GetAll(filter);
        }

        public Agency GetById(int id)
        {
            return _agencyDal.GetById(id);
        }

        public Agency GetOne(Expression<Func<Agency, bool>> filter = null)
        {
            return _agencyDal.GetOne(filter);
        }

        public void Update(Agency entity)
        {
            _agencyDal.Update(entity);
        }
    }
}
