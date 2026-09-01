public class Inventory
{

    List <Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (Item item in items)
        {
            Console.WriteLine($" {item.Name} - {item.Value} ");
        }
    }
}