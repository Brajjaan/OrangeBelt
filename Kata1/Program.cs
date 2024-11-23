namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Character warrior = new("Warrior", 45);
        Character healer = new("Healer", 55);
        
        warrior.PrimaryAction = () => Console.WriteLine("Warrior is attacking!");

        healer.PrimaryAction = () =>
        {
            //Ternary operator to decide who recieves healing
            Character target = (warrior.Health < healer.Health) ? warrior : healer;
            int healAmount = 15;
            target.Health += healAmount;
            Console.WriteLine($"Healer heals {target.Name} for {healAmount} health");
            Console.WriteLine($"{target.Name} has {target.Health} health");
        };
        var characters = new[] { warrior, healer };

        for (int turn = 1; turn <= 3; turn++)
        {
            Console.WriteLine("Turn " + turn);
            foreach (var character in characters.OrderByDescending(character => character.Health < 50))
            {
                character.PrimaryAction();
            }
        }
    }
}