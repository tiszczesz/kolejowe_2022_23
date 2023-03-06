using Microsoft.AspNetCore.Mvc;
using MVC_cw2_v2.Models;

namespace MVC_cw2_v2.Controllers
{
    public class SecondController : Controller
    {
        public PrimaryGenerator Pg { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.isPost = false;
            Pg = new PrimaryGenerator();
            return View(Pg);
        }

        [HttpPost]
        public IActionResult Index(PrimaryGenerator pg)
        {
            ViewBag.isPost = true;
            if (ModelState.IsValid)
            {
                //todo
            }
            return View(Pg);
        }
    }
}
