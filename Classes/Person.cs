public class Person
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

