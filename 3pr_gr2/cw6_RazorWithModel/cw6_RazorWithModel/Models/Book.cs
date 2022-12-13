

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw6_RazorWithModel.Models
{
    public class Book
    {
        public int Id { get; set; }

        [DisplayName("Tytuł książki")]
        public string Title { get; set; }
        [DisplayName("Autor książki")]
        public string Author { get; set; }

        [DisplayName("Data wydania")]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }
    }
}
