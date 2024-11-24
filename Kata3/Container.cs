namespace Kata3;

public class AbilityContainer<T> where T : IAbility
{
    private List<T> _abilities = new();

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }

    public void RemoveAbility(T ability)
    {
        _abilities.Remove(ability);
    }

    public IEnumerable<T> GetAbilities() // I saw this in the C# and .NET features, what's its purpose?
    {
        return _abilities;
    }

    public void PrintAbilities()
    {
        foreach (var ability in _abilities)
        {
            Console.WriteLine($"Ability: {ability.Name}. Effect: {ability.Effect}");
        }
    }
}