using cw6_RazorWithModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6_RazorWithModel.Pages
{
    public class AddBookModel : PageModel
    {
        public Book  MyBook { get; set; }
        public void OnGet()
        {
            MyBook = new Book();
        }
        public void OnPost()
        {
            ViewData["post"] = true;
        }
    }
}
