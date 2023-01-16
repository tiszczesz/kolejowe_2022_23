using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebRazorModelSelect.Models
{
	public class Student
	{
		 

		[Required(ErrorMessage = "Podaj imię")]
		[MinLength(3,ErrorMessage = "Trzy znaki minimum")]
		[Display(Name = "Podaj imię")]
		public string? FirstName { get; set; }


		[Required(ErrorMessage = "Podaj nazwisko")]
		[MinLength(3, ErrorMessage = "Trzy znaki minimum")]
		[Display(Name = "Podaj nazwisko")]
		public string? LastName { get; set; }

		[DisplayName("Wybierz klasę")]
		public string Division { get; set; }

		[DisplayName("Płeć")]
		public string Gender { get; set; } = "Kobieta";

		[DisplayName("Zainteresowania")]
		public List<CheckItem> Hobbies { get; set; }
	}
}
