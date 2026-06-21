using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
