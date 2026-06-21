using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Layout
{
    public class _LayoutFooterViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
