namespace MySql_v1_wycieczki.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string? Place { get; set; }
        public decimal? Price { get; set; }
        public DateOnly? Date { get; set; }

    }
}
