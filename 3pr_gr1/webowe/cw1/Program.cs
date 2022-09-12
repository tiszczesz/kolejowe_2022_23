// See https://aka.ms/new-console-template for more information
Console.Write("Podaj imie: ");
string? firstName=Console.ReadLine();
Console.Write("Podaj nazwisko: ");
string? lastName=Console.ReadLine();
Console.Write("Podaj wiek: ");
int age = Convert.ToInt32(Console.ReadLine());
var wynik = age>=18 ? "pelnoletni" : "niepelnoletni";
Console.WriteLine(
@$"Witaj {firstName} {lastName} {wynik} dzisiaj jest: 
       {DateTime.Now.ToShortDateString()}");
