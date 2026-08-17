static class NumberArray
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 7, 42, 18 };
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[4]);
        Console.WriteLine(numbers.Length);

        foreach (var number in numbers)
        {

            if (number >= 20)
            {
            Console.WriteLine(number + " ist groß");
            }

            else
            {
                Console.WriteLine(number + " ist klein");
            }
        }
    }
}