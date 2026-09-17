// Ett kod för klass Car som representerar en bil med egenskaper för märke, modell och år. Klassen har en metod Printinfo som skriver ut information om bilen.
public class Car
// Här under har jag skrvit en klass Car som representerar en bil med egenskaper för märke, modell och år. Klassen har en metod Printinfo som skriver ut information om bilen.
{
    public string Brand;

    public string Model;

    public int Year;

    public void Printinfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }

}
