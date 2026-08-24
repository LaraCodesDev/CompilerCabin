public static class SaveGame
{
    public static void Run()
    {
        if (File.Exists("06_Files/savegame.txt"))
        {
            string text = File.ReadAllText("06_Files/savegame.txt");
            Console.WriteLine("Spielstand gefunden: " + text);
        }
        else
        {
            Console.WriteLine("Wie heißt dein Charakter?");
            string savegame = Console.ReadLine() ?? "";
            File.WriteAllText("06_Files/savegame.txt", savegame);
            Console.WriteLine("Spielstand wurde erstellt!");

        }
    }
}