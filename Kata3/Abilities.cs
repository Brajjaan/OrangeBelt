namespace Kata3;

public interface IAbility
{
    string Name { get; }
    string Effect { get; set; }
}

public class AttackAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}

public class HealAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}

