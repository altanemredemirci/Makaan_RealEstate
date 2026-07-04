using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.SliderDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.About
{
    public class _AboutHeaderViewComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;
        
        public _AboutHeaderViewComponentPartial(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<ResultSliderDTO>(_sliderService.GetAll(i => i.Page == "About")));
        }
    }
}
