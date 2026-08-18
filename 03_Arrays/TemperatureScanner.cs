static class temperatureScanner
{
    public static void Run()
    {
         int[] temperatures = { 18, 24, 31, 16, 28, 35, 21 };

        foreach (var zahl in temperatures)
        {
        if (zahl < 20)
        {
            Console.WriteLine(zahl + " kalt");
        }

        else if (zahl >= 30)
        {
            Console.WriteLine(zahl + " heiß");
        }

        else
        {
            Console.WriteLine(zahl + " angenehm");
        }
    }
}