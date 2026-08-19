using System.Runtime.CompilerServices;

static class NumberAnalyzer
{
   public static void Run()
   {
        int[] numbers = { 4, 7, 12, 15, 18, 21, 24, 31 };
        int gerade = 0;
        foreach (var number in numbers)
        {
            if (number % 2 ==0)
            {
                gerade++;
            }
        }
        Console.WriteLine("Gerade Zahlen "+ gerade); 
   } 
} 




