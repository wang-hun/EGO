using Microsoft.AspNetCore.Mvc;

namespace WebEGO.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
