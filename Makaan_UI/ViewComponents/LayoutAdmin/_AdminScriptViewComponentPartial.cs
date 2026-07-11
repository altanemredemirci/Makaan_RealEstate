using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.ViewComponents.LayoutAdmin
{
    public class _AdminScriptViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
