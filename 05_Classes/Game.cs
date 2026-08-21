class Game
{
    public string Titel;

    private int price;

    public int Price
    {
        get
        {
            return price;
            
        }
        set
        {
           if (value >=0)
            {
                price = value;
            }
            else
            {
                Console.WriteLine("Price cannot be negative!");
            } 
        }
    }
    public int Age;

    public Game(string titel, int price, int age)
    {
        Titel = titel;
        Price = price;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Titel +" | Price: " + Price + " | Age: " + Age);
    }

    public void IsAllowed()
    {
        if (Age >=18)
        {
            Console.WriteLine("This game is for adults.");
        }
        else
        {
            Console.WriteLine("This game is for minors.");
        }
    }
}