class Dog
{
    public string Name;
    public int Age;
    public string Breed;

    public void Bark()
    {
        Console.WriteLine(Name + " says Woof!");
    }

    public void Introduce()
    {
       Console.WriteLine("My Name is " + Name + ", I am " + Age + " Years old and I am a " + Breed);
    }

    public void Eat(string food)
    {
        if (food == "Chicken")
        {
           Console.WriteLine(Name + " loves Chicken!"); 
        }
        else
        {
            Console.WriteLine(Name + " eats " + food);
        }
    }

    public void CheckAge()
    {
        if (Age >= 5)
        {
            Console.WriteLine(Name + " is an adult dog!");
        }
        else
        {
            Console.WriteLine(Name + " is an young dog!");
        }
    }
    public Dog(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }
}