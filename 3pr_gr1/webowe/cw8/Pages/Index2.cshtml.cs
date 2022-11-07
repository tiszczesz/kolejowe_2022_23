using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Index2Model : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GetAge(){
            return DateTime.Now.Year - BirthDate.Year;
        }
        public void OnGet()
        {
            FirstName = "Sławek";
            LastName = "Nowak";
            BirthDate = new DateTime(2000,6,7);
        }
    }
}
