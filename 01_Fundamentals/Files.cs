public static class Files
{
    public static void Run()
    {
        // --------------------------------------------------
        // FILES
        // --------------------------------------------------
        // Mit File können Dateien erstellt, beschrieben,
        // gelesen und überprüft werden.


        // --------------------------------------------------
        // WriteAllText
        // --------------------------------------------------
        // Schreibt Text in eine Datei.
        // Existiert die Datei noch nicht, wird sie erstellt.
        // Existiert sie bereits, wird der alte Inhalt überschrieben.

        File.WriteAllText("hello.txt", "Hello from C#!");


        // --------------------------------------------------
        // ReadAllText
        // --------------------------------------------------
        // Liest den gesamten Inhalt einer Datei.
        // Der gelesene Text kann in einem string gespeichert werden.

        string text = File.ReadAllText("hello.txt");

        Console.WriteLine(text);


        // --------------------------------------------------
        // AppendAllText
        // --------------------------------------------------
        // Fügt neuen Text am Ende einer Datei hinzu.
        // Der vorhandene Inhalt bleibt erhalten.

        File.AppendAllText("hello.txt", "\nSecond Line!");


        // --------------------------------------------------
        // File.Exists
        // --------------------------------------------------
        // Prüft, ob eine Datei existiert.
        // File.Exists gibt einen bool zurück:
        //
        // true  = Datei existiert
        // false = Datei existiert nicht

        if (File.Exists("hello.txt"))
        {
            Console.WriteLine("File exists!");
        }


        // --------------------------------------------------
        // \n
        // --------------------------------------------------
        // \n erzeugt einen Zeilenumbruch innerhalb eines Strings.

        File.AppendAllText("hello.txt", "\nNew Line!");


        // --------------------------------------------------
        // PFADE
        // --------------------------------------------------
        // Ein Dateiname allein:
        //
        // "hello.txt"
        //
        // bedeutet:
        // Die Datei wird relativ zum aktuellen Arbeitsordner gesucht.
        //
        // ../ bedeutet:
        // Einen Ordner nach oben gehen.
        //
        // Beispiel:
        //
        // "../../../06_Files/hello.txt"
        //
        // geht drei Ordner nach oben und anschließend
        // in den Ordner 06_Files.
        //
        // Bei Windows-Pfaden kann @ vor dem String verwendet werden:
        //
        // @"L:\TestBilder"
        //
        // Dadurch müssen die Backslashes nicht doppelt geschrieben werden.


        // --------------------------------------------------
        // TYPISCHER ABLAUF
        // --------------------------------------------------
        // Erst prüfen, ob die Datei existiert.
        // Danach lesen und ausgeben.

        if (File.Exists("hello.txt"))
        {
            string content = File.ReadAllText("hello.txt");

            Console.WriteLine(content);
        }


        // --------------------------------------------------
        // Directory.GetFiles
        // --------------------------------------------------
        // Holt alle Dateien aus einem Ordner.
        //
        // Directory.GetFiles gibt mehrere Dateipfade zurück.
        // Deshalb können die Ergebnisse in einem string-Array
        // gespeichert werden.

        string[] files = Directory.GetFiles(@"L:\TestBilder");


        // --------------------------------------------------
        // Dateien mit foreach durchlaufen
        // --------------------------------------------------
        // Jeder Eintrag im Array ist ein vollständiger Dateipfad.

        foreach (var file in files)
        {
            Console.WriteLine(file);
        }


        // --------------------------------------------------
        // Path.GetFileName
        // --------------------------------------------------
        // Holt nur den Dateinamen aus einem vollständigen Pfad.
        //
        // Beispiel:
        //
        // L:\TestBilder\IMG_3817.jpg
        //
        // wird zu:
        //
        // IMG_3817.jpg

        foreach (var file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}