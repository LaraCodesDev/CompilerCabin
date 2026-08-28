public static class LevelException
{
    public static void Run()
    {
        Console.WriteLine("Gib deinen Level ein");
        string input = Console.ReadLine()??"";

        try
        {
            int level = int.Parse(input);
            Console.WriteLine($"dein lvl ist {level}");
        }

        catch(FormatException)
        {
            Console.WriteLine("Kartoffel detected!");
        }

        

    }
}