using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorPageGames.Models;

namespace WebRazorPageGames.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private RepoGames _repo = new RepoGames();

    
        public List<Game> Games { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _repo.GenerGames();
        }

        public void OnGet()
        {
            Games = _repo.Games;
        }
    }
}