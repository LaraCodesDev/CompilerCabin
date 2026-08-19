static class Variables
{
    public static void Run()
    {
        // --------------------
        // Variablen
        // --------------------

        // string speichert Text.
        string name = "Lara";

        // int speichert ganze Zahlen.
        int age = 32;

        // double speichert Zahlen mit Nachkommastellen.
        double temperature = 22.5;

        // bool kann nur true oder false speichern.
        bool learningCSharp = true;


        // --------------------
        // Variablen ausgeben
        // --------------------

        // Mit + können Variablen an einen Text angehängt werden.
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Learning C#: " + learningCSharp);
    }
}