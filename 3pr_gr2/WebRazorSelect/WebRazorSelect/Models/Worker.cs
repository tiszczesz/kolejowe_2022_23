using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebRazorSelect.Models
{
    public class Worker
    {
        [Required(ErrorMessage = "Podaj imię")]
        [DisplayName("Podaj imię")]
        [MinLength(3,ErrorMessage = "Muszą być 3 litery")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [DisplayName("Podaj nazwisko")]
        [MinLength(3, ErrorMessage = "Muszą być 3 litery")]
        public string? LastName { get; set; }

        [DisplayName("Miejsce pracy")]
        public string Workplace { get; set; }

        [DisplayName("Pensja")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
    }
}
