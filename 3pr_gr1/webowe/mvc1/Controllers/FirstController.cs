using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index(){

            return View();
        }
        public IActionResult MyAction(){
            return View();
        }
    }
}
