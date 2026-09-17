// Här skriver jag en abstrakt klass Animal som har en abstrakt metod MakeSound. Sedan skapar vi två konkreta klasser Dog och Cat som ärver från Animal och implementerar MakeSound-metoden för att skriva ut respektive djurljud.
abstract class Animal
{
    public abstract void MakeSound();
}

// Här skapar vi två konkreta klasser Dog och Cat som ärver från Animal och implementerar MakeSound-metoden.
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says Woof!");
    }
}
// Här skapar vi två konkreta klasser Dog och Cat som ärver från Animal och implementerar MakeSound-metoden.
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says Meow!");
    }
}