using cw6_RazorWithModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6_RazorWithModel.Pages
{
    public class AddBookModel : PageModel
    {
        private RepoBooks _repo;
        public AddBookModel()
        {
            _repo = new RepoBooks();
        }
        [BindProperty]
        public Book  MyBook { get; set; }
        public void OnGet()
        {
            MyBook = new Book();
            
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
                _repo.SaveToFile("books.txt",MyBook);
                return new RedirectToPageResult("Index");
            }
            return Page();
        }
    }
}
