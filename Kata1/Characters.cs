namespace Kata1;

class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public Action PrimaryAction { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}
