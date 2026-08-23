public static class PlayerSave
{
    public static void Run()
    {
        if (File.Exists("06_Files/player.txt"))
        {
           string text = File.ReadAllText("06_Files/player.txt");
           Console.WriteLine(text); 
        }
        else
        {
            Console.WriteLine("Wie heißt dein Spieler?");
            string playerName = Console.ReadLine()??"";

            Console.WriteLine("Welches level bist du?");
            int level = int.Parse(Console.ReadLine()??"");

            File.AppendAllText("06_Files/player.txt", $"Name: {playerName}\nLevel: {level}");
        }
    }
}