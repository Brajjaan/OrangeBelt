namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        AbilityContainer<IAbility> abilityContainer = new();
        AttackAbility frostSpike = new("Frost Spike", "Deals 50 points of physical and stamina damage");
        AttackAbility slash = new("Slash", "Deals 100 points of physical damage");
        abilityContainer.AddAbility(frostSpike);
        abilityContainer.AddAbility(slash);
        
        HealAbility mend = new("Mend", "Heals 50 of health and restores 5 points of health overtime for 10s");
        HealAbility heal = new("Heal", "Heals 100 points of health");
        abilityContainer.AddAbility(mend);
        abilityContainer.AddAbility(heal);
        
        Console.WriteLine("Printing abilities:");
        abilityContainer.PrintAbilities();
        
        Console.WriteLine();
        abilityContainer.RemoveAbility(frostSpike);
        abilityContainer.RemoveAbility(mend);
        
        Console.WriteLine("Printing new abilities:");
        abilityContainer.PrintAbilities();
    }
}