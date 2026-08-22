using System.Net.Security;

public static class WriteFile

{
    public static void Run()
    {
        if (File.Exists("../../../06_Files/hello.txt"))
        {
            string text = File.ReadAllText("../../../06_Files/hello.txt");
            Console.WriteLine(text);
        }
        
        File.AppendAllText("../../../06_Files/hello.txt", "\nLearning Files!");
    }
}