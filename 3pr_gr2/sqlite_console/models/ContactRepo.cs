using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace sqlite_console.models
{
    public class ContactRepo
    {
        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            using (var conn =
            new SqliteConnection("Data Source=contacts.db"))
            {
                try
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "SELECT * FROM MyContacts";
                    SqliteDataReader rd = command.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            contacts.Add(
                                new Contact
                                {
                                    Id = rd.GetInt32(0),
                                    FirstName = rd.GetString(1),
                                    LastName = rd.GetString(2),
                                    Email = rd.GetString(3)
                                }
                            );
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return contacts;
        }
    }
}