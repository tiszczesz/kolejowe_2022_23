using Microsoft.AspNetCore.Mvc;
using MVC_cw2.Models;
using System.Diagnostics;

namespace MVC_cw2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.controller = ControllerContext
               .RouteData.Values["Controller"].ToString();
            ViewBag.action = ControllerContext
                .RouteData.Values["action"].ToString();
            return View();
        }

        public IActionResult Privacy()
        {
  
            return View();
        }
        public IActionResult Akcja2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}