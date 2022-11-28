namespace Web1.Models
{
    public class ContactsRepo
    {
        public List<Contact> Contacts { get; set; }
        private string _fileName;

        public ContactsRepo(string fileName)
        {
            _fileName = fileName;
            Contacts = new List<Contact>();
            if (File.Exists(_fileName))
            {
                LoadFromFile(_fileName);
            } 
        }
        public static List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact{Id = 1,Firstname = "Adam",Lastname = "Nowak",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 2,Firstname = "Monika",Lastname = "Jarych",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 3,Firstname = "Tomasz",Lastname = "Bomasz",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
                new Contact{Id = 4,Firstname = "Teresa",Lastname = "Hajduk",Email = "hg@onet.pl",PhoneNumber = "2344-24242"},
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
        public void LoadFromFile(string fileName)
        {
            var data = File.ReadAllLines(fileName);
            foreach(var item in data)
            {
                var contact = item.Split('|');
                if (contact.Length == 5)
                {
                    Contact c = new Contact
                    {
                        Id = Convert.ToInt32(contact[0]),
                        Firstname = contact[1],
                        Lastname = contact[2],
                        Email = contact[3],
                        PhoneNumber = contact[4]
                    };
                    Contacts.Add(c);
                }                
            }
        }
    }
}
