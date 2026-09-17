// Här har jag skrivit en klass Person som representerar en person med egenskaper för namn och ålder. Klassen har en metod PersonInfo som skriver ut information om personen.
public class Person
// Attributen för Person-klassen inkluderar namn och ålder, samt en konstruktor som tar emot dessa värden som parametrar. Klassen har också en metod PersonInfo som skriver ut information om personen.
{
    public string Name;

    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");

    }
}

