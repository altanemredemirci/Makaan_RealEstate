using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeTestimonialViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
