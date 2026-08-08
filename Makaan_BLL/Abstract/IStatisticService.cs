using System;
using System.Collections.Generic;
using System.Text;

namespace Makaan_BLL.Abstract
{
    public interface IStatisticService
    {
        int ProductTypeCount();
        int ActiveProductTypeCount();
        int PassiveProductTypeCount();
        int ProductCount();
        string TopAgencyByProductCount();
        string TopProductTypeByProductCount();
        decimal AvgProductBySale();
        decimal AvgProductByRent();
        string TopCityByProductCount();
        int DiffrentCityCount();
        decimal LastProductPrice();
        decimal TheMostExpensiveProduct();
        decimal CheapestProduct();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int ActiveAgencyCount();
    }
}
}
