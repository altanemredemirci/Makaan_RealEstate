using Makaan_BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomePropertyViewComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _HomePropertyViewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
