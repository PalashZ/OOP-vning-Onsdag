public class Student : Person
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