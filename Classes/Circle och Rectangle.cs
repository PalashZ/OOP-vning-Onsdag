// Här har jag skapat ett subklass för Shape som representerar en cirkel och en rektangel. Båda subklasserna har egenskaper för färg och area, samt metoder för att beräkna och skriva ut arean. Detta ska demonstrera arv och polymorfism i C#.
public class Circle : Shape
{
    // Attributen för Circle-klassen inkluderar färg och radie, samt en konstruktor som beräknar arean baserat på radien.
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
// Attributen för Rectangle-klassen inkluderar färg, bredd och höjd, samt en konstruktor som beräknar arean baserat på bredden och höjden.
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