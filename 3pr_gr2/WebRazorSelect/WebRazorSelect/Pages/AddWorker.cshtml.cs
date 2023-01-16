using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebRazorSelect.Models;

namespace WebRazorSelect.Pages
{
    public class AddWorkerModel : PageModel
    {
        [BindProperty]
        public Worker MyWorker { get; set; }
        public List<string> WorkerPlaces { get; set; }
        public List<SelectListItem> WorkerPlace2 { get; set; }
        public List<string> Genders { get; set; }
        public AddWorkerModel()
        {
            WorkerPlaces = new List<string>
            {
                "Asystent/ka","handlowiec","kierowca","sprz¹tacz/ka","kierownik"
            };
            WorkerPlace2 = new List<SelectListItem> { 
                new SelectListItem{
                    Text="Asystent/ka",Value="Asystent/ka"},
                 new SelectListItem{
                    Text="handlowiec",Value="handlowiec"},
                  new SelectListItem{
                    Text="kierowca",Value="kierowca"},
                   new SelectListItem{
                    Text="kierownik",Value="kierownik"}
            };
            Genders = new List<string> { "Kobieta", "Mê¿czyzna", "Inna" };
            MyWorker.Hobbies = new List<HobbyItem>
            {
                new HobbyItem{Name = "Ksi¹¿ki"},
                new HobbyItem{Name = "Filmy"},
                new HobbyItem{Name = "Sport"},
                new HobbyItem{Name = "Muzyka"},
                new HobbyItem{Name = "Teatr"},
                new HobbyItem{Name = "Taniec"}
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
