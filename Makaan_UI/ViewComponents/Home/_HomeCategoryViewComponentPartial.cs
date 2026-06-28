using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeCategoryViewComponentPartial:ViewComponent
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;
        public _HomeCategoryViewComponentPartial(IProductTypeService productTypeService,IMapper mapper)
        {
            _productTypeService = productTypeService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var productTypes = _productTypeService.GetAll();
            return View(_mapper.Map<List<ResultProductTypeDTO>>(productTypes));
        }
    }
}
