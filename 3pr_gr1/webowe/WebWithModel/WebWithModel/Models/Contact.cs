using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebWithModel.Models
{
	public class Contact
	{
		public int Id { get; set; }

		[DisplayName("Podaj imię")]
		[Required(ErrorMessage = "Musisz podać imię")]
		public string FirstName { get; set; }

		[DisplayName("Podaj nazwisko")]
		[Required(ErrorMessage = "Musisz podać nazwisko")]
		[MinLength(3,ErrorMessage ="Co najmniej 3 litery w nazwisku")]
		public string LastName { get; set; }

		[DisplayName("Podaj telefon")]
		[Required(ErrorMessage = "Musisz podać telefon")]
		public string Phone { get; set; }

		[DisplayName("Podaj adres email")]
		[Required(ErrorMessage = "Musisz podać email")]
		public string Email { get; set; }
	}
}
