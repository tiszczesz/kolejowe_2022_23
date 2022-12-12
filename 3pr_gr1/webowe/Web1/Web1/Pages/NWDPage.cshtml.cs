using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;

namespace Web1.Pages
{
    public class NWDPage : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            int a = 30;//var ff = Request.Form;
            int b = 45;
            int result = NWD.NWDRec(a, b);
            var choice = Request.Form["wybor"];
            switch (choice)
            {
                case "iter":
                    //tu robimy iteracyjnie
                    break;
                case "rec":
                    //tu robimy rekurencyjnie
                    break;
               
                    default:
                    //tu robimy  domyslnie rekurencyjnie
                    break;
            }
            var ff = Request.Form;
        }
    }
}
