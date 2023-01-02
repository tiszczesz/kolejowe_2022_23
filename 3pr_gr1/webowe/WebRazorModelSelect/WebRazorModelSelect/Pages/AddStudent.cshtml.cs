using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebRazorModelSelect.Models;

namespace WebRazorModelSelect.Pages
{
    
    public class AddStudentModel : PageModel
    {
		[BindProperty]
        public Student MyStudent { get; set; }
        public List<string> Divisions { get; set; }
        public List<SelectListItem> Divisions2 { get; set; }
        public AddStudentModel()
        {
			Divisions = new List<string>
			{
				"1A","1B","1C","1PrA","1PrB"
			};
			Divisions2 = new List<SelectListItem>
			{
				
                new SelectListItem{Text="1A" ,Value="1A"},
                new SelectListItem{Text="1B" ,Value="1B"},
                new SelectListItem{Text="1C" ,Value="1C"},
                new SelectListItem{Text="1D" ,Value="1D"}
                
			};
		}
        public void OnGet()
        {
            
            
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                ViewData["success"] = true;
            }
            else
            {
				
			}
            
        }
    }
}
