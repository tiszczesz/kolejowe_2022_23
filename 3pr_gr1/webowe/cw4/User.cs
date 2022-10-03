
class User
{
    private string login = "noname";
    public string Login{
        get{return login.ToUpper();}
        private set{login=value;}
    }
    private string password = "noname";
    public string Password{
         get{return password;}
        set{password = value;}
    }
    public User()
    {
        login = "z konstuktora";
        password = "z konstuktora";
    }
    public User(string login,string password){
        this.login = login;
        this.password = password;
    }
    public override string ToString()
    {
        return base.ToString()+ $" ---->login: {login} haslo: {password}";
    }
}

