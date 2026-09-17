namespace OOP_Övning_Onsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lakk, Shooo!");

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

            Balance Saldo = new Balance(3000 , 200);
            Saldo.ShowBalance();
            Saldo.DepositAmount(500);
            Saldo.WithdrawAmount(300);
            Saldo.ShowBalance();

            Animal Dog = new Dog();
            Dog.MakeSound();

            Animal Cat = new Cat();
            Cat.MakeSound();

            Person student2 = new Person("Nemo", 30);
            student2.PersonInfo();

            Student student1 = new Student ("Palash", 22, "12345");
            student1.PrintStudentInfo();

            Shape Circle = new Circle("Red", 5);
            Circle.GetArea();

            Shape Rectangle = new Rectangle("Blue", 10, 5);
            Rectangle.GetArea();

        }
    }
}

