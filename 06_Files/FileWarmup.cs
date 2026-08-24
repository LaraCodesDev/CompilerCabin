public static class FileWarmup
{
    public static void Run()
    {
        Console.WriteLine("Was möchtest du speichern?");
        string text = Console.ReadLine()??"";

        File.WriteAllText("06_Files/note.txt", text);
        string textnew = File.ReadAllText("06_Files/note.txt");
        Console.WriteLine($"Gespeicherte Notiz: {textnew}");



    }
}