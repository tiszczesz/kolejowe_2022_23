using System.Text;

//Console.Write("Podaj imie: ");
//string? firstName = Console.ReadLine();
// if(firstName!=null)  Hello(firstName);
string[] names = {"Adam","Roman","Edyta","Malina","ggggg","alina","marian","Anna"};
// for(int i=0;i<names.Length;i++){
//     Hello(names[i]);
// }
// foreach(var elem in names){
//     Hello(elem);
// }
// Console.WriteLine(HelloUpper(names));
GetByFirstChar(names,"a");

foreach(var elem in GetByFirstCharLinq(names,"m")){
    Console.WriteLine($"LINQ: {elem}");
}

void Hello(string name){
    Console.WriteLine($"Hello {name} dzisiaj mamy {DateTime.Now.ToShortDateString()}");
}
string HelloUpper(string[] data){
    // string result = "";
    // foreach(var elem in data){
    //     result+=elem.ToUpper()+" ";
    // }
    StringBuilder sb = new StringBuilder();
     foreach(var elem in data){
        sb.Append(elem).Append(" ");
    }
    return sb.ToString();
}
void GetByFirstChar(string[] data,string c){
    foreach(var elem in data){
        if(elem.ToLower().StartsWith(c.ToLower())){
            Console.WriteLine(elem);
        }
    }
}
List<string> GetByFirstCharLinq(string[] data,string c){
    return data.Where((e) =>  e.ToLower().StartsWith(c.ToLower())).ToList();
}