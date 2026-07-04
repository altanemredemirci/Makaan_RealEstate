using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.AgencyDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeTeamViewComponentPartial:ViewComponent
    {
        private readonly IAgencyService _agencyService;
        private readonly IMapper _mapper;

        public _HomeTeamViewComponentPartial(IAgencyService agencyService, IMapper mapper)
        {
            _agencyService = agencyService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var agencies = _agencyService.GetAll(i => i.Status);
            var model = _mapper.Map<List<ResultAgencyDTO>>(agencies);
            return View(model);
        }
    }
}
