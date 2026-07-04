using Makaan_BLL.Abstract;
using Makaan_DAL.Abstract;
using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Makaan_BLL.Concrete
{
    public class ClientService : IClientService
    {
        private readonly IClientDal _clientDal;

        public ClientService(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }
        public void Create(Client entity)
        {
            _clientDal.Create(entity);
        }

        public void Delete(Client entity)
        {
            _clientDal.Delete(entity);
        }

        public List<Client> GetAll(Expression<Func<Client, bool>> filter = null)
        {
            return _clientDal.GetAll(filter);
        }

        public Client GetById(int id)
        {
            return _clientDal.GetById(id);
        }

        public void Update(Client entity)
        {
            _clientDal.Update(entity);
        }
    }
}
