public class Item
{
    public string Name {get; set;}
    public int Value {get; set;}

    public Item(string name, int value)
    {
        this.Name = name;
        this.Value = value; 
    }
}