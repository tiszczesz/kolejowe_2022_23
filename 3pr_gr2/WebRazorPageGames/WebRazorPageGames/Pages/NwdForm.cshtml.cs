using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorPageGames.Models;

namespace WebRazorPageGames.Pages
{
    public class NwdFormModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["post"] = true;
            try
            {
                int a = Convert.ToInt32(Request.Form["a"]);
                int b = Convert.ToInt32(Request.Form["b"]);
                if(a>=0 && b >= 0)
                {
                    if (Request.Form["wybor"]=="rec")
                        ViewData["result"] = $"Rekurencyjnie: NWD({a},{b}) = {Nwd.NwdRec(a, b)}";
                    else
                        ViewData["result"] = $"Iteracyjnie: NWD({a},{b}) = {Nwd.NwdIter(a, b)}";
                }
                else
                {
                    ViewData["result"] = "B³êdne dane";
                }

            }catch(FormatException ex)
            {
                ViewData["result"] = "B³êdne dane";
            }
           
        }
    }
}
