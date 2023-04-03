using System.ComponentModel;

namespace MySql_v1_wycieczki.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [DisplayName("Miejsce wycieczki")]
        public string? Place { get; set; }

        [DisplayName("Cena")]
        public decimal? Price { get; set; }

        [DisplayName("Data wycieczki")]
        public DateOnly? Date { get; set; }

    }
}
