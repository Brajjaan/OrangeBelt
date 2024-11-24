namespace Kata2;

public delegate void CharacterAction(Character target);

public class Character
{
    public string Name { get; }
    public int Health { get; private set; }

    public event Action<Character> HealthChanged;

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Character target)
    {
        CharacterAction attackAction = target.TakeDamage;
        attackAction.Invoke(target);
    }

    public void TakeDamage(Character target)
    {
        int damage = 10; 
        target.Health -= damage;
        target.HealthChanged.Invoke(target);
    }
}