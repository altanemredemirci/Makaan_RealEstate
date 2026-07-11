using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
