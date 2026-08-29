using System.Runtime.CompilerServices;

public class Inventory
{

    List <string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}