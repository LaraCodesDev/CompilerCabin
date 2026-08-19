static class InputOutput
{
    public static void Run()
    {
        // Console.WriteLine() gibt Text oder Werte in der Konsole aus.
        Console.WriteLine("Hallo!");

        // Console.ReadLine() wartet auf eine Eingabe des Benutzers.
        // Die Eingabe wird immer zuerst als string (Text) zurückgegeben.
        string name = Console.ReadLine()??"";

        // Variablen können mit + an einen Text angehängt werden.
        Console.WriteLine("Hallo " + name);
    }
}