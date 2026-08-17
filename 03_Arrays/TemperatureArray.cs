static class TemperatureArray
{
    public static void Run()
    {
        int[] numbers = { 12, 45, 7, 23, 81, 16 };

        int largest = numbers[0];

        foreach (var number in numbers)
        {

            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine("The largest number is: " + largest);

    }
}