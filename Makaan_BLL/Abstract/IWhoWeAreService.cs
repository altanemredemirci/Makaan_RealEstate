using Makaan_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface IWhoWeAreService
    {
        WhoWeAre GetOne();
        void Update(WhoWeAre entity);
    }
}
