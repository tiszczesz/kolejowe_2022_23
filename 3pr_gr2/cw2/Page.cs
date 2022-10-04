class Page{
    private string title;
    public string Title{
        get{return title.ToUpper();}
       private set{title = value;}
    }
    private string content;
    public string Content{
        get{return content;}
        set{content=value;}
    }
    public Page()
    {
        Title = "Noname";
        Content = "Hello world";        
    }
    public Page(string title,string content,string author = "user"){
        Title = title;
        Content = content;
    }
    public override string ToString(){
        return $"tytul: {Title} zawartosc: {Content} autor: {Author}";
    }
    public string Author { get; set; } = "user";
}