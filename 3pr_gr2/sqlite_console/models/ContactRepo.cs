using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace sqlite_console.models
{
    public class ContactRepo
    {
        public void GetContacts(){
            using (var conn = 
            new SqliteConnection("Data Source=contacts.db")){
                conn.Open();
            }
        }
    }
}