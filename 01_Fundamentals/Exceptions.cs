public static class Exceptions
{
    public static void Run()
    {
        // EXCEPTIONS – QUICK REFERENCE

        // try = code that might cause an exception
        // catch = handles a specific exception


        // FORMAT EXCEPTION
        // Happens when a value has the wrong format.
        // Example: "Kartoffel" cannot be converted to int.

        try
        {
            int number = int.Parse("Kartoffel");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format.");
        }


        // OVERFLOW EXCEPTION
        // Happens when a number is too large or too small for int.

        try
        {
            int number = int.Parse("999999999999999999999");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is outside the range of int.");
        }


        // FILE NOT FOUND EXCEPTION
        // Happens when trying to access a file that does not exist.

        try
        {
            string text = File.ReadAllText("Example.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }


        // MULTIPLE CATCH BLOCKS
        // One try block can handle different exceptions separately.

        try
        {
            string input = Console.ReadLine() ?? "";
            int number = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small.");
        }
    }
}