static class GameChecker
{
    public static void Run()
    {
        int alter = 0;
        Console.WriteLine("Alter");
        alter = int.Parse(Console.ReadLine() ?? "");

        string game = "Ja";
        game = Console.ReadLine() ?? "";

        string gamepass = "Ja";
        gamepass = Console.ReadLine() ?? "";

        if (alter >= 16 && (game == "ja" || gamepass == "ja"))
        {
        Console.WriteLine("Spiel wird gestartet!");
        }

        else
        {
            Console.WriteLine("Spiel kann nicht gestartet werden!");  
        }
    }
}