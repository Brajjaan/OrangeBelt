namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        Character knight = new("Knight", 100);
        Character mage = new("Mage", 80);

        knight.HealthChanged += Printable.PrintHealthChanged;
        mage.HealthChanged += Printable.PrintHealthChanged;

        Console.WriteLine($"{knight.Name} attacks {mage.Name}!");
        knight.Attack(mage);

        Console.WriteLine($"{mage.Name} attacks {knight.Name}!");
        mage.Attack(knight);        
    }
}