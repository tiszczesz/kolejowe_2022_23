public class Animal{
    private double mass;
    private string name;    
    public Animal(){
        mass = 0;
        name = "noname";
        Console.WriteLine("Konstruktor domyslny klasy Animal");
    }
    public Animal(string name,double mass)    {
        Mass = mass;
        this.name = name;
        Console.WriteLine("Konstruktorz argumentami klasy Animal");
    }
    public Animal(Animal a){
        Console.WriteLine("Konstruktor kopiujacy");
    }
    public double Mass{
        get{ return mass;}
        set{mass = value>0? value: -value;}
    }
    public virtual string Info(){
        return $"Zwierzak {name} o masie: {Mass}";
    }
}