using Microsoft.AspNetCore.Mvc;
using Sqlite.web.Models;
using sqlite_console;
using System.Diagnostics;

namespace Sqlite.web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ProductRepo repo;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			repo = new ProductRepo();
		}

		public IActionResult Index()
		{
			var products = repo.GetProductsToList();
			return View(products);
		}

		public IActionResult Privacy()
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