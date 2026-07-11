using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;

        public ProductTypeController(IProductTypeService productTypeService,IMapper mapper)
        {
            _productTypeService=productTypeService;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
            var productTypes = _productTypeService.GetAll();
            var models = _mapper.Map<List<ResultProductTypeDTO>>(productTypes);
            return View(models);
        }
    }
}
