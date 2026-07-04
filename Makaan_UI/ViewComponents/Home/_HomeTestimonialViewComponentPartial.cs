using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ClientDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeTestimonialViewComponentPartial:ViewComponent
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public _HomeTestimonialViewComponentPartial(IClientService clientService,IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var clients = _clientService.GetAll();
            var model = _mapper.Map<List<ResultClientDTO>>(clients);
            return View(model);
        }
    }
}
