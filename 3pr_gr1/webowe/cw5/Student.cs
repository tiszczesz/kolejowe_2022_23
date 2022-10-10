public class Student
{
    private string firstName;
    public string FirstName{
        get{ return firstName.ToUpper();}
        private set { firstName = value;}
    }
   
    private string lastName;
    private List<double> grades;
    public Student()
    {
        firstName = "noname";
        lastName = "noname";
        grades = new List<double>();
    }
    public Student(string firstName, string lastName, List<double> grades = null)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.grades = grades != null ? grades : new List<double>();
    }
    public double GetAVG(){
        return grades.Average();
    }
    public override string ToString()
    {
        string allGrades = String.Join(" ", grades);
        return $"{FirstName}|{lastName}|{allGrades} srednia: "+ GetAVG().ToString("#.##");
    }
    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }
}