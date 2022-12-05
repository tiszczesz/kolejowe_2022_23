using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1.Pages
{
    public class MyFormModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var req = Request;
            var form = req.Form;
            ViewData["post"] = true;
            ViewData["firstname"] = Request.Form["firstname"];
            ViewData["lastname"] = Request.Form["lastname"];
        }
    }
}
