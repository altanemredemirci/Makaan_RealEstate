using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ContactDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Contact
{
    public class _ContactStartViewComponentPartial:ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public _ContactStartViewComponentPartial(IContactService contactService, IMapper mapper)
        {
            _contactService= contactService;
            _mapper= mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<ResultContactDTO>(_contactService.GetOne()));
        }
    }
}
