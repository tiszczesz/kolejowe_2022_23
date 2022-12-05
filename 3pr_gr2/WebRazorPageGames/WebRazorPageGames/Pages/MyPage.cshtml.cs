using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazorPageGames.Pages
{
    public class MyPageModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var req = Request;
            var form = Request.Form;
            ViewData["post"] = true;
        }
    }
}
