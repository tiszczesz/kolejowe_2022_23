using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public List<string> Users { get; set; }
        public void OnGet()
        {
            Users = new List<string>{
                "root","user1","user2","dddd"
            };
        }
    }
}
