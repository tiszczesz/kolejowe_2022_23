string[] names = {"Ala","Bella","Tomasz","Roman","Teresa","Tadeusz","tttt"};

ShowAll(names);
Console.WriteLine(" =========================================");
ShowAll(ShowOnlyStartWith(names,"t").ToArray());
Console.WriteLine(" =========================================");
ShowAll(ShowWithLinq(names,"t").ToArray());
Console.WriteLine(" =========================================");
ShowAll(names.Where(e=>e.ToLower().Contains("al".ToLower())).ToArray());



//tools
void ShowAll(string[] data){
    foreach(var elem in data){
        Console.WriteLine(elem);
    }
}
List<string> ShowOnlyStartWith(string[] data,string c){
    List<string> result = new List<string>();
    foreach(var elem in data){
        if( elem.ToLower().StartsWith( c.ToLower())){
            result.Add(elem);
        }
    }
    return result;
}
List<string> ShowWithLinq(string[] data,string c){
    return data.Where(e =>e.ToLower().StartsWith(c.ToLower())).ToList();
}

