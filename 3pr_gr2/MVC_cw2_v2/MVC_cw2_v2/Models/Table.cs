namespace MVC_cw2_v2.Models
{
    public class Table
    {
        public int Limit { get; set; }
        public Table(int limit = 10)
        {
            Limit = limit;
        }
        public string Html { get; set; }
    }
}
