using System.ComponentModel;

namespace MySql_v1_products.Models
{
    public class Product
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Nazwa prduktu")]
        public string? Name { get; set; }
        [DisplayName("Cena")]
        public decimal? Price { get; set; }

        [DisplayName("Opis produktu")]
        public string? Description { get; set; }
    }
}
