using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomePopularProductViewComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _HomePopularProductViewComponentPartial(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ResultProductDTO>>(_productService.GetPopularAll()));
        }
    }
}
