using Microsoft.AspNetCore.Mvc;

namespace MVC_cw2_v2.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
