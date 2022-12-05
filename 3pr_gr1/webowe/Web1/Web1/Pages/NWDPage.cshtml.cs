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
            int a = 12;
            int b = 45;
            int result = NWD.NWDRec(a, b);
            var ff = Request.Form;
        }
    }
}
