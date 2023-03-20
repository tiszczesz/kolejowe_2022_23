using Microsoft.AspNetCore.Mvc;
using MySql_v1_products.Models;
using System.Diagnostics;

namespace MySql_v1_products.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string connString;
        private ProductRepo _productRepo;

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            connString = configuration.GetConnectionString("MySqlConn");
            _productRepo = new ProductRepo(connString);
        }

        public IActionResult Index() {
            var products = _productRepo.GetProducts();
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