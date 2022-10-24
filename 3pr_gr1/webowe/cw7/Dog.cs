public class Dog : Animal {
    private string sound;
    public Dog(){
        sound = "hau hau";
        Console.WriteLine("Konstruktor domyslny klasy Dog");
    }
    public Dog(string name,double mass,string sound)
    :base(name,mass)
    {
        this.sound = sound;
        Console.WriteLine("Konstruktor z argumentami klasy Dog");
    }
    public override string Info(){
        return base.Info()+ $"daj glos: {sound}";
    }
}