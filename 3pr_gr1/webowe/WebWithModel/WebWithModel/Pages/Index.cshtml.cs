using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWithModel.Models;

namespace WebWithModel.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public FileRepoContacts Repo { get; set; }
		
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
			Repo = new FileRepoContacts();
		}

		public void OnGet()
		{

		}
	}
}