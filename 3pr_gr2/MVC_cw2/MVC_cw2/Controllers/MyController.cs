using Microsoft.AspNetCore.Mvc;

namespace MVC_cw2.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
