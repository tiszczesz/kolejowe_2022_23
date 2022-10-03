User u1 = new User();
User u2 = new User("Tomasz","qaz");
// u2.Login = "fffff";
Console.WriteLine(u1.Login);
Console.Write($"{u1.Login} czy chcesz zmienic haslo: (t/n) ");
char isChange = Console.ReadLine()[0];
if(Char.ToLower(isChange)=='t'){
    Console.Write("Podaj haslo: ");
    u1.Password = Console.ReadLine();
}
Console.WriteLine(u1);