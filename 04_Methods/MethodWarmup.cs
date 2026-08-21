static class MethodWarmup
{
    static void Run()
    {
        int result = CalculatePrice(20,3);
        Console.WriteLine("Total Price: "+ result);
    }
    static int CalculatePrice(int price, int amount)
    {
        return price * amount;
    }
}