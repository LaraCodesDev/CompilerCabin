static class DogDemo
{
    public static void Run()
    {
        Dog maya = new Dog("Maya", 4, "Westie");
        maya.Breed = "";
        maya.Age = -10;
        maya.Bark();
        maya.Introduce();
        maya.Eat("Chicken");
        maya.CheckAge();

        Console.WriteLine(maya.Age);

        Dog pascha = new Dog("Pascha", 7, "Labbi");
        pascha.Bark();
        pascha.Introduce();
        pascha.Eat("Beef");
        pascha.CheckAge();

        Console.WriteLine(pascha.Name + " " + pascha.Age + " " + pascha.Breed);
    }
}