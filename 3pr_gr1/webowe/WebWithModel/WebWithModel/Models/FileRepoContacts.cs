using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebWithModel.Models
{
	public class FileRepoContacts
	{
		private string _fileName = "contacts.txt";
		public List<Contact> Contacts { get; set; }

		public FileRepoContacts() {
			if (File.Exists(_fileName))
			{
				Contacts = new List<Contact>();
				LoadFromFile();
			}
			else
			{
				Contacts = new List<Contact>();
			}
		}

		public void SaveToFile() {
			List<string> toSave = new List<string>();
			if(Contacts != null && Contacts.Count>0) {		
				foreach(var c in Contacts)
				{
					toSave.Add(JsonSerializer.Serialize(c));
				}
				File.WriteAllLines(_fileName,toSave);				
			}
		}
		public void LoadFromFile()
		{
			List<string> result = File.ReadAllLines(_fileName).ToList();
			foreach(var line in result)
			{
				var c = JsonSerializer.Deserialize<Contact>(line);
				if(c!=null) { 
					Contacts.Add(c); 
				}
			}
		}
	}
}
