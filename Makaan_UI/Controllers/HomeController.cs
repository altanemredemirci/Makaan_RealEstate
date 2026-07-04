using Makaan_BLL.Abstract;
using Makaan_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Makaan_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
