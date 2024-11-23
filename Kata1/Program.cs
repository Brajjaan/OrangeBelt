namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Character warrior = new("Warrior", 55);
        Character healer = new("Healer", 45);
        
        warrior.PrimaryAction = () => Console.WriteLine("Warrior is attacking!");

        healer.PrimaryAction = () =>
        {
            //Ternary operator to decide who receives healing
            Character target = (warrior.Health < healer.Health) ? warrior : healer;
            int healAmount = 10;
            target.Health += healAmount;
            Console.WriteLine($"Healer heals {target.Name} for {healAmount} health");
            Console.WriteLine($"{target.Name} has {target.Health} health");
        };
        var characters = new[] { warrior, healer };
        
        Console.WriteLine($"{warrior.Name} has {warrior.Health} health");
        Console.WriteLine($"{healer.Name} has {healer.Health} health");
        Console.WriteLine();

        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine("Turn " + turn);
            foreach (var character in characters.OrderByDescending(c => c.Health < 50).ThenByDescending(c => c.Health))
            {
                character.PrimaryAction();
            }
            //This is to test that the < 50 condition works :)
            if (turn % 2 == 0) 
            {
                warrior.Health -= 20;
                Console.WriteLine($"Warrior takes 20 damage!");              
            }
        }
    }
}