using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorSelect.Models;

namespace WebRazorSelect.Pages
{
    public class AddWorkerModel : PageModel
    {
        [BindProperty]
        public Worker MyWorker { get; set; }
        public List<string> WorkerPlaces { get; set; }
        public AddWorkerModel()
        {
            WorkerPlaces = new List<string>
            {
                "Asystent/ka","handlowiec","kierowca","sprz¹tacz/ka","kierownik"
            };
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["post"] = true;
            if (ModelState.IsValid)
            {
                var result = MyWorker;
            }
            else
            {

            }
        }
    }
}
