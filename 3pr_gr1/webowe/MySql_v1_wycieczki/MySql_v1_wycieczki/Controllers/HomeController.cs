using Microsoft.AspNetCore.Mvc;
using MySql_v1_wycieczki.Models;
using System.Diagnostics;

namespace MySql_v1_wycieczki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        TripRepo tripRepo;

        public HomeController(ILogger<HomeController> logger,
                 IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("myConn");
            tripRepo = new TripRepo(connString);

            _logger = logger;
        }

        public IActionResult Index()
        {
            var trips = tripRepo.GetAll();
            return View(trips);
        }
        [HttpGet]
        public IActionResult AddTrip()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTrip(Trip trip)
        {
            return View();
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