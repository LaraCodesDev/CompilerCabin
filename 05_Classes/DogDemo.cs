using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

static class DogDemo
{
    public static void Run()
    {
        Dog maya = new Dog("Maya", 4, "Westie");
        maya.Bark();
        maya.Introduce();
        maya.Eat("Chicken");
        maya.CheckAge();

        Console.WriteLine(maya.Name +" "+ maya.Age +" "+ maya.Breed);

        Dog pascha = new Dog("Pascha", 7, "Labbi");
        pascha.Bark();
        pascha.Introduce();
        pascha.Eat("Beef");
        pascha.CheckAge();

        Console.WriteLine(pascha.Name + " " + pascha.Age + " " + pascha.Breed);
    }
}