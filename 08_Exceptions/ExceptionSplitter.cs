public static class ExceptionSplitter
{
    public static void Run()
    {
        Console.WriteLine("Was ist dein Level?");
        string input = Console.ReadLine()??"";
        try
        {
            int level = int.Parse(input);
        }
        catch(FormatException)
        {
            Console.WriteLine("❌ Falsches Item! Der Splitter erwartet eine Zahl, keine Kartoffel.");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Falsche Zahl! Der Splitter erwartet eine normale Zahl, keine Grübchen.");
        }

        
    }
}
