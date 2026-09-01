class CombatPlayer
{
    string name;
    int health;
    Weapon weapon;
    Inventory inventory;

    public CombatPlayer(string name, int health, Weapon weapon, Inventory inventory)
    {
        this.name = name;
        this.health = health;
        this.weapon = weapon;
        this.inventory = inventory;
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

    public void PickUpItem(Item item)
    {
        inventory.AddItem(item);
    }

    public void ShowInventory()
    {
        inventory.ShowItems();
    }
}
