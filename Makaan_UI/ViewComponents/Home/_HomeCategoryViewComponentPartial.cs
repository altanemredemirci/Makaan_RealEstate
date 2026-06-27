using Makaan_BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeCategoryViewComponentPartial:ViewComponent
    {
        private readonly IProductTypeService _productTypeService;

        public _HomeCategoryViewComponentPartial(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }
        public IViewComponentResult Invoke()
        {
            var productTypes = _productTypeService.GetAll();
            return View(productTypes);
        }
    }
}
