using Microsoft.AspNetCore.Mvc;
using MVC_Mysql_v1.Models;
using System.Diagnostics;

namespace MVC_Mysql_v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string connString;
        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            connString = configuration.GetConnectionString("mysqlconn");
        }

        public IActionResult Index()
        {
            var repo = new FilmRepo(connString);
            var films = repo.GetFilms();
            return View(films);
        }

        [HttpGet]
       public IActionResult AddFilm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFilm(Film film)
        {
            if (ModelState.IsValid)
            {
                var repo = new FilmRepo(connString);
                repo.AddFilms(film);
                return RedirectToAction("Index");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}