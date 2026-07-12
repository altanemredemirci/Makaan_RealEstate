using Makaan_BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService= cityService;
        }
        public IActionResult GetDistricts(int cityId)
        {
            var districts = _cityService.GetDistrictById(cityId);
            return Json(districts);
        }
    }
}
