using System.Text.Json;

class GameSaveManager
{
    public static void Run()
    {
        PlayerSaveData Kevin = new PlayerSaveData();
        Kevin.Name = "Kevin";
        Kevin.Level = 1;
        Kevin.Experience = 0;
        Kevin.Health = 100;
        Kevin.Inventory.Add("Flashlight");
        Kevin.Inventory.Add("Duck");

        string json = JsonSerializer.Serialize(Kevin);
        Console.WriteLine(json);
        File.WriteAllText("savegame.json", json);
        string loadedJson = File.ReadAllText("savegame.json");
        PlayerSaveData? loadedKevin = JsonSerializer.Deserialize<PlayerSaveData>(loadedJson);

        if (loadedKevin != null)
        {
            Console.WriteLine(loadedKevin.Name);
        }
    
    
    }
}