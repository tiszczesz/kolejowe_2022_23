class Person {
    protected string firstName;
    protected string lastName;
    public DateTime? BirthDate{get;set;}
    public Person()
    {
        Console.WriteLine("Konstruktor domyslany Person");
        firstName = "noname";
        lastName = "noname";
        BirthDate = DateTime.Now;
    }
    public Person(string firstName,string lastName,DateTime? birthDate = null)
    {
        Console.WriteLine("Konstruktor z argumentami Person");
        this.firstName = firstName;
        this.lastName = lastName;
        BirthDate = birthDate ?? DateTime.Now;
    }
    public override string ToString()
    {
        return $"{firstName} {lastName} data urodzenia: {BirthDate} wiek: {GetAge()}";
    }
    public int GetAge(){
        if(BirthDate.HasValue){
            return DateTime.Now.Year -  BirthDate.Value.Year;
        }        
        return 0;
    }
}