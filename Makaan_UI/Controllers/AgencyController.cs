using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.AgencyDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class AgencyController : Controller
    {
        private readonly IAgencyService _agencyService;
        private readonly IMapper _mapper;

        public AgencyController(IAgencyService agencyService,IMapper mapper)
        {
            _agencyService = agencyService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var agencies = _agencyService.GetAll();
            var model = _mapper.Map<List<ResultAgencyDTO>>(agencies);
            return View(model);
        }
    }
}
