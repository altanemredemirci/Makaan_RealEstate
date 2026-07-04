using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.WhoWeAreDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial:ViewComponent
    {
        private readonly IWhoWeAreService _whoWeAreService;
        private readonly IMapper _mapper;

        public _HomeAboutViewComponentPartial(IWhoWeAreService whoWeAreService, IMapper mapper)
        {
            _whoWeAreService = whoWeAreService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var whoWeAre = _whoWeAreService.GetOne();
            var model = _mapper.Map<ResultWhoWeAreDTO>(whoWeAre);
           
            return View(model);
        }
    }
}
