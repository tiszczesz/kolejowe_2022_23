using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWithModel.Models;

namespace WebWithModel.Pages
{
    public class AddContactModel : PageModel
    {
        [BindProperty]
        public Contact  MyContact { get; set; }
        public FileRepoContacts MyRepo { get; set; }
        public AddContactModel()
        {
            MyRepo = new FileRepoContacts();
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                MyRepo.Contacts.Add(MyContact);
                MyRepo.SaveToFile();
                return new RedirectToPageResult("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
