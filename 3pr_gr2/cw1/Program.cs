string[] names = {"Ala","Bella","Tomasz","Roman","Teresa","Tadeusz","tttt"};

ShowAll(names);
Console.WriteLine(" =========================================");
ShowAll(ShowOnlyStartWith(names,"t").ToArray());



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

