using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.Home
{
    public class _HomeHeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
