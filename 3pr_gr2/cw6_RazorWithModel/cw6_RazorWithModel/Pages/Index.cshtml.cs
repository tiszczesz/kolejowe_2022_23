using cw6_RazorWithModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6_RazorWithModel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public RepoBooks Repo { get; set; }
       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Repo = new RepoBooks();
        }

        public void OnGet()
        {

        }
    }
}