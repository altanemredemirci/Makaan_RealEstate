using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Layout
{
    public class _LayoutNavbarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
