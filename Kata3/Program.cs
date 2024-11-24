namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        AbilityContainer<AttackAbility> attackContainer = new();
        AttackAbility frostSpike = new("Frost Spike", "Deals 50 points of physical and stamina damage");
        AttackAbility slash = new("Slash", "Deals 100 points of physical damage");
        attackContainer.AddAbility(frostSpike);
        attackContainer.AddAbility(slash);
        
        AbilityContainer<HealAbility> healContainer = new();
        HealAbility mend = new("Mend", "Heals 50 of health and restores 5 points of health overtime for 10s");
        HealAbility heal = new("Heal", "Heals 100 points of health");
        healContainer.AddAbility(mend);
        healContainer.AddAbility(heal);
        
        Console.WriteLine("Printing abilities:");
        attackContainer.PrintAbilities();
        healContainer.PrintAbilities();
        
        Console.WriteLine();
        attackContainer.RemoveAbility(frostSpike);
        healContainer.RemoveAbility(mend);
        
        Console.WriteLine("Printing new abilities:");
        attackContainer.PrintAbilities();
        healContainer.PrintAbilities();
        
    }
}