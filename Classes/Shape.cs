// Här har jag skrivit en klass Shape som representerar en geometrisk figur med egenskaper för färg och area. Klassen har en metod GetArea som skriver ut arean av figuren.
public class Shape
// Attributen för Shape-klassen inkluderar färg och area, samt en metod GetArea som skriver ut arean av figuren.
{
    public string Color;

    public string Area;

    public void GetArea()
    {
        Console.WriteLine($"Area: {Area}");
    }   
}