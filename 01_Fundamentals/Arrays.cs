static class Arrays
{
    public static void Run()
    {
        // Ein Array besitzt eine feste Größe.

        int[] numbers =
        {
            10,
            20,
            30,
            40
        };


        // Zugriff über den Index.
        // Der erste Index ist immer 0.

        Console.WriteLine(numbers[0]);

        // Ausgabe:
        // 10


        string[] games =
        {
            "Bendy",
            "Horizon",
            "Minecraft"
        };

        Console.WriteLine(games[1]);

        // Ausgabe:
        // Horizon


        // foreach kann benutzt werden,
        // um alle Werte durchzugehen.

        foreach (string game in games)
        {
            Console.WriteLine(game);
        }


        // Length zeigt die Anzahl der Elemente.

        Console.WriteLine(games.Length);
    }
}