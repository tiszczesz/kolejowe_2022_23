using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public List<string> Names { get; set; }
        public void OnGet()
        {
            Names = new List<string>{"ala","bela","cela"};
            int a = 12;
        }
    }
}
