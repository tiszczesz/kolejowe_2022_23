class Circle{
     private double radius;
    public double Radius{
        get {return radius;}
        set { radius = value<0 ? -value : value;}
    }
    public Circle()
    {
        Radius = 10;
    }
    public Circle(double radius)
    {
        Radius = radius;
    }
}