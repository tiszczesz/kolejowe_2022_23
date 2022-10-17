using Microsoft.AspNetCore.Mvc;

namespace mymvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
