namespace Web1.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{Id}|{Firstname}|{Lastname}|{Email}|{PhoneNumber}";           
        }
    }
}
