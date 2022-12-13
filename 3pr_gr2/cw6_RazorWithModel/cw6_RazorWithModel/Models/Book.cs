

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw6_RazorWithModel.Models
{
    public class Book
    {
        public int Id { get; set; }

        [DisplayName("Tytuł książki")]
        [Required(ErrorMessage ="Proszę podać tytuł")]
        [MinLength(2,ErrorMessage ="Tyuł musi posiadać minimum 2 znaki")]
        public string Title { get; set; }
        [DisplayName("Autor książki")]
        [Required(ErrorMessage = "Proszę podać autora")]
        public string Author { get; set; }

        [DisplayName("Data wydania")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Proszę wybrać datę wydania")]
        public DateTime Date { get; set; }
    }
}
