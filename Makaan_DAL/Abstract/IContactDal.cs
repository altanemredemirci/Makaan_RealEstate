using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_DAL.Abstract
{
    public interface IContactDal
    {
        Contact GetOne();
        void Update(Contact entity);
    }
}
