using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;

namespace Web1.Pages
{
    public class MyPageModel : PageModel
    {
        public void OnGet()
        {
            ContactsRepo.SaveToFile("dane.txt", ContactsRepo.GetContacts());
        }
    }
}
