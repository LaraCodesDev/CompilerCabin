static class Operators
{
    public static void Run()
    {
        int number = 10;

        // --------------------
        // Rechenoperatoren
        // --------------------

        Console.WriteLine(number + 5);  // Addition
        Console.WriteLine(number - 5);  // Subtraktion
        Console.WriteLine(number * 2);  // Multiplikation
        Console.WriteLine(number / 2);  // Division


        // --------------------
        // Modulo %
        // --------------------

        // % gibt den REST einer Division zurück.
        // 10 / 2 hat keinen Rest -> Ergebnis von 10 % 2 ist 0.
        Console.WriteLine(number % 2);

        // Deshalb kann man mit % prüfen, ob eine Zahl gerade ist:
        // number % 2 == 0


        // --------------------
        // ++ und --
        // --------------------

        // ++ erhöht eine Zahl um 1.
        number++;

        // -- verringert eine Zahl um 1.
        number--;


        // --------------------
        // Vergleichsoperatoren
        // --------------------

        // Vergleiche ergeben immer true oder false.
        Console.WriteLine(number > 5);    // größer als
        Console.WriteLine(number < 20);   // kleiner als
        Console.WriteLine(number >= 10);  // größer oder gleich
        Console.WriteLine(number <= 10);  // kleiner oder gleich
        Console.WriteLine(number == 10);  // gleich
        Console.WriteLine(number != 10);  // ungleich


        // --------------------
        // Logische Operatoren
        // --------------------

        // && bedeutet UND.
        // Beide Bedingungen müssen true sein.
        Console.WriteLine(number > 5 && number < 20);

        // || bedeutet ODER.
        // Mindestens eine Bedingung muss true sein.
        Console.WriteLine(number < 5 || number == 10);

        // ! bedeutet NICHT und kehrt einen bool-Wert um.
        bool isActive = true;
        Console.WriteLine(!isActive); // ergibt false
    }
}