using Microsoft.AspNetCore.Mvc;
using MVC_cw2_v2.Models;
using MVC_cw2_v2.ViewModels;
using System.Text;

namespace MVC_cw2_v2.Controllers
{
    public class SecondController : Controller
    {
        public PrimaryGenerator Pg { get; set; }
        public PrimalsViewModel  PrimalVM { get; set; }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.isPost = false;
            PrimalVM = new PrimalsViewModel();
            PrimalVM.PG = new PrimaryGenerator();
            return View(PrimalVM);
        }

        [HttpPost]
        public IActionResult Index(PrimalsViewModel primalVM)
        {
            ViewBag.isPost = true;
            primalVM.HtmlTable = "";
            var ff = ModelState.IsValid;
            primalVM.HtmlTable = GenerTab(primalVM.PG.N ?? 0, primalVM.PG); 
            //return View(PrimalVM);
           
            return View(primalVM);
        }
        public IActionResult GenerTab(){
            int limit = 25;
            Table t = new Table(limit);
            PrimaryGenerator pg = new PrimaryGenerator();
            t.Html = GenerTab(limit, pg);
            return View(t);
        }
        private string GenerTab(int limit ,PrimaryGenerator pg )
        {

            StringBuilder html = new StringBuilder("<table class='table table-bordered'>");
            int rows = limit / 20 + 1;
            const int cols = 20;
            int number = 0;
            for (int i = 0; i < rows; i++)
            {
                html.Append("<tr>");
                for (int j = 0; j < cols; j++)

                {
                    number++;
                    string primal = pg.IsPrimal(number) ? "class='primal'" : "";

                    html.Append($"<td {primal}>{number}</td>");
                }
                html.Append("</tr>");
            }
            html.Append("</table>");
           return  html.ToString();
        }
    }
}
