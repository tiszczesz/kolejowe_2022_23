using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;

namespace Web1.Pages
{
    public class MyPageModel : PageModel
    {
        private ContactsRepo contactsRepo;
        public MyPageModel()
        {
            contactsRepo = new ContactsRepo("dane.txt");
        }
        public void OnGet()
        {
            
        }
    }
}
