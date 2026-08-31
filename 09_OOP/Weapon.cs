public class Weapon
{
    string name;
    int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} attacks for {damage} damage!");
    }
}