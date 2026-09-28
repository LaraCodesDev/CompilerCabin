public class PlayerSaveData
{
    public string Name { get; set;} ="";
    public int Level { get; set;}
    public int Experience { get; set;}
    public float Health { get; set; }
    public List<string> Inventory { get; set; } = new();
}