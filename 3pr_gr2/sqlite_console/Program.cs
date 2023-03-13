// See https://aka.ms/new-console-template for more information
using sqlite_console.models;

Console.WriteLine("Hello, World!");
ContactRepo repo = new ContactRepo();
var contacts = repo.GetContacts();
foreach(var c in contacts){
    Console.WriteLine($"Imię: {c.FirstName} Nazwisko: {c.LastName} Email: {c.Email}");

}
repo.InsertContact(
    new Contact{FirstName="Alojzy",LastName="Gąbka",Email="ff@hh.pl"});