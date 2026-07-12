using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,IMapper mapper)
        {
            _productService=productService;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
            var products = _mapper.Map<List<ResultProductDTO>>(_productService.GetAll());
            return View(products);
        }
    }
}
