using Microsoft.AspNetCore.Mvc;
using MVC_first_v2.Models;

namespace MVC_first_v2.Controllers
{
	public class EuklidesController : Controller
	{
		public MyNWD GenerNWD { get; set; }

		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.isPost = false;
			GenerNWD = new MyNWD();
			return View(GenerNWD);
		}

		[HttpPost]
		public IActionResult Index(MyNWD nwd)
		{
			ViewBag.isPost = true;
			if (ModelState.IsValid)
			{

			}
			return View(nwd);
		}
	}
}
