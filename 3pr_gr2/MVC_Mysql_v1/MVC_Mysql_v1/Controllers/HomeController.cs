using Microsoft.AspNetCore.Mvc;
using MVC_Mysql_v1.Models;
using System.Diagnostics;

namespace MVC_Mysql_v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string connString;
        private FilmRepo _repo;
        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            connString = configuration.GetConnectionString("mysqlconn");
            _repo = new FilmRepo(connString);
        }

        public IActionResult Index()
        {
            
            var films = _repo.GetFilms();
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
                _repo.AddFilms(film);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Film? film = _repo.GetById(id);
            if (film == null) return RedirectToAction("Index");
            return View(film); //return View("AddFilm",film);
        }
        [HttpPost]
        public IActionResult Update(int id, Film film)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateFilm(id, film);
                return RedirectToAction("Index");
            }
            return View(film);
        }

        public IActionResult Delete(int id)
        {           
            _repo.DeleteFilms(id);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}