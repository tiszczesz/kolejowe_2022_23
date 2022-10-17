using Microsoft.AspNetCore.Mvc;
using mymvc.Data;
using mymvc.Models;

namespace mymvc.Controllers
{
    public class StudentController : Controller
    {
        MyDbContext _db;
        public StudentController(MyDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var students = _db.Students.ToList();
            return View(students);
        }
    }
}
