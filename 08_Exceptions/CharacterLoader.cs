public static class CharacterLoader
{
    public static void Run()
    {
        Console.WriteLine("Was ist dein Level?");
        string input = Console.ReadLine();
        
        try
        {
            int level = int.Parse(input);
            Console.WriteLine($"Dein lvl ist {level}");
        }

        catch (FormatException)
        {
            Console.WriteLine("Keine gültige Zahl eingegeben try again later");           
        }

        catch (OverflowException)
        {
            Console.WriteLine("Junge, so hoch ist dein Level auch wieder nicht! 😂");
        }

        try
        {
           string text = File.ReadAllText("character.txt");
           Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Nix gefunden");
        }

    }
}