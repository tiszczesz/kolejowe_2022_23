class Page{
    private string title;
    public string Title{
        get{return title;}
        set{title = value;}
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
    public Page(string title,string content){
        Title = title;
        Content = content;
    }
    public override string ToString(){
        return base.ToString();
    }
    
}