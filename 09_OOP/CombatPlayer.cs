class CombatPlayer
{
    string name;
    int health;
    Weapon weapon;

    public CombatPlayer(string name, int health, Weapon weapon)
    {
        this.name = name;
        this.health = health;
        this.weapon = weapon;
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;

        if (health <= 0)
        {
            Console.WriteLine($"{name} ist defeated");
        }
    }

    public void Attack()
    {
        weapon.Attack();
    }
}
