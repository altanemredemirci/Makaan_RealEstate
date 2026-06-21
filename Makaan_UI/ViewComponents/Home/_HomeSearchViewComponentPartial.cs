using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeSearchViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
