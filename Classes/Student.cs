// Här har jag skrivit en klass Student som ärver från Person-klassen och representerar en student med egenskaper för namn, ålder och student-ID. Klassen har en metod PrintStudentInfo som skriver ut information om studenten.
public class Student : Person
// Attributen för Student-klassen inkluderar student-ID, samt en konstruktor som tar emot namn, ålder och student-ID som parametrar. Klassen har också en metod PrintStudentInfo som skriver ut information om studenten.
{

    public string Studentid;

    public Student(string name, int age, string studentid) : base(name, age)
    {
        Studentid = studentid;
    }

    public new void PrintStudentInfo()
    {
        base.PersonInfo();

        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {Studentid}");
    }

    public void StudentInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {Studentid}");
    }
}

// Med denna klassen fick jag förklara hur ett arv skulle funka