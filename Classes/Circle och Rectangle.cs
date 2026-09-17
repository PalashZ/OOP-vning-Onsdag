public class Circle : Shape
{
    public double Radius;
    public Circle(string color, double radius)
    {
        Color = color;
        Radius = radius;
        Area = (Math.PI * Math.Pow(Radius, 2)).ToString();
    }
    public virtual void GetArea()
    {
        Console.WriteLine($"Circle Area: {Area}");
    }
}

public class Rectangle : Shape
{
    public double Width;
    public double Height;
    public Rectangle(string color, double width, double height)
    {
        Color = color;
        Width = width;
        Height = height;
        Area = (Width * Height).ToString();
    }
    public virtual void GetArea()
    {
        Console.WriteLine($"Rectangle Area: {Area}");
    }
}