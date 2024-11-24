namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        static void PrintHealthChanged(Character character) // I think this is what was asked??
        {
            Console.WriteLine($"{character.Name}'s health is now {character.Health}.");
        }
        
        Character knight = new Character("Knight", 100);
        Character mage = new Character("Mage", 80);

        knight.HealthChanged += PrintHealthChanged;
        mage.HealthChanged += PrintHealthChanged;

        Console.WriteLine($"{knight.Name} attacks {mage.Name}!");
        knight.Attack(mage);

        Console.WriteLine($"{mage.Name} attacks {knight.Name}!");
        mage.Attack(knight);        
    }
}