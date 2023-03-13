// See https://aka.ms/new-console-template for more information
using sqlite_console.models;

Console.WriteLine("Hello, World!");
ContactRepo repo = new ContactRepo();
repo.GetContacts();