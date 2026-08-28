public static class FileException
{
    public static void Run()
    {
        try
        {
            string text = File.ReadAllText("Kartoffel.txt");
        }
        catch(FileNotFoundException)
        {
           Console.WriteLine("Kartoffel.txt existiert nicht!");
        }
    }
}