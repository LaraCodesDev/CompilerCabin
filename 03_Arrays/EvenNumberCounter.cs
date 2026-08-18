static class EvenNumberCounter
{
    public static void Run()
    {
        int[] numbers = { 4, 7, 12, 19, 22, 31, 40, 55 };

        int gerade = 0;

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                gerade++;
            }

        }
        Console.WriteLine("Gerade Zahlen "+ gerade);
    }
}