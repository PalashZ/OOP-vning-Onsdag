namespace OOP_Övning_Onsdag
{
    internal class Program
    {

        // Här under skriver vi vår kod i Main-metoden. Vi skapar objekt av klasserna Car, Balance, Animal, Person och Shape och anropar deras metoder för att visa information och utföra olika operationer.
        static void Main(string[] args)
        {
            Console.WriteLine("Tjena bästa Nemo!");

            // Skapa objekt av klassen Car och sätt dess egenskaper
            Car Ferarri = new Car();
            Ferarri.Brand = "Ferrari";
            Ferarri.Model = "SF90";
            Ferarri.Year = 2015;
            Ferarri.Printinfo();

            Car MercedesBenz = new Car();
            MercedesBenz.Brand = "Mercedes-Benz";
            MercedesBenz.Model = "S-Class";
            MercedesBenz.Year = 2020;
            MercedesBenz.Printinfo();

            // Skapa objekt av klassen Balance och utför insättning och uttag
            Balance Saldo = new Balance(3000 , 200);
            Saldo.ShowBalance();
            Saldo.DepositAmount(500);
            Saldo.WithdrawAmount(300);
            Saldo.ShowBalance();

            // Skapa objekt av klassen Animal och anropa dess metod MakeSound
            Animal Dog = new Dog();
            Dog.MakeSound();
            Animal Cat = new Cat();
            Cat.MakeSound();

            // Skapa objekt av klassen Person och anropa dess metod PersonInfo
            Person student2 = new Person("Nemo", 30);
            student2.PersonInfo();
            Student student1 = new Student ("Palash", 22, "12345");
            student1.PrintStudentInfo();

            // Skapa objekt av klassen Shape och anropa dess metod GetArea
            Shape Circle = new Circle("Red", 5);
            Circle.GetArea();
            Shape Rectangle = new Rectangle("Blue", 10, 5);
            Rectangle.GetArea();

        }
    }
}

