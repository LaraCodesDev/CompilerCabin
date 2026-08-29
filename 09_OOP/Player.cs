class Player
{
    Inventory inventory = new Inventory();

    public void PickUpItem(string item)
    {
        inventory.AddItem(item);
    }
    public void ShowInventory()
    {
        inventory.ShowItems();
    }
}
