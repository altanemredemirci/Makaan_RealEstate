using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.SliderDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Contact
{
    public class _ContactHeaderViewComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public _ContactHeaderViewComponentPartial(ISliderService sliderService,IMapper mapper)
        {
            _mapper = mapper;
            _sliderService=sliderService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<ResultSliderDTO>(_sliderService.GetAll(i => i.Page == "Contact")));
        }

    }
}
