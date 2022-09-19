// See https://aka.ms/new-console-template for more information
Console.Write("podaj a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("podaj b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("wybierz dzialanie (+,-,*,/): ");
char doIt = Console.ReadLine()[0];
if(doIt=='+'){
    Console.WriteLine($"{a} + {b} = {a+b}");
}else if(doIt=='-'){
    Console.WriteLine($"{a} - {b} = {a-b}");
}else if(doIt=='*'){
    Console.WriteLine($"{a} * {b} = {a*b}");
}else if(doIt=='/'){
    var wynik = b!=0 ? ((double)a/b).ToString("0.00")
         : "nie dzielimy przez zero";
    Console.WriteLine($"{a} / {b} = {wynik}");
}else{
    Console.WriteLine("Złe działanie!!!");
}
