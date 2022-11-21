namespace Web1.Models
{
    public class ContactsRepo
    {
        public static List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact{Id = 1,Firstname = "Adam",Lastname = "Nowak",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 1,Firstname = "Monika",Lastname = "Jarych",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 1,Firstname = "Tomasz",Lastname = "Bomasz",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 1,Firstname = "Teresa",Lastname = "Hajduk",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
            };
        }
        public static void SaveToFile(string fileName, List<Contact> list)
        {
            var listString = new List<string>();
            foreach (var item in list)
            {
                listString.Add(item.ToString());
            }
            File.WriteAllLines(fileName, listString.ToArray());
        }
    }
}
