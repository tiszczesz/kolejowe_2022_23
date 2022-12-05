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

            ViewData["post"] = true;
            ViewData["title"] = Request.Form["title"];
            ViewData["category"] = Request.Form["category"];
            ViewData["releaseDate"] = Request.Form["releaseDate"];
        }
    }
}
