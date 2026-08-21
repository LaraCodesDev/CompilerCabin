// ============================================
// CLASSES / KLASSEN
// ============================================

// Eine Klasse ist ein Bauplan für Objekte.
//
// Beispiel:
//
// class Game
// {
// }


// ============================================
// FELDER
// ============================================

// Felder speichern Daten innerhalb einer Klasse.
//
// public  = auch von außerhalb erreichbar
// private = nur innerhalb der Klasse erreichbar
//
// Beispiel:
//
// public string Title;
// private int price;


// ============================================
// PROPERTY MIT GET / SET
// ============================================

// Eine Property kontrolliert den Zugriff auf einen Wert.
//
// Beispiel:
//
// public int Price
// {
//     get
//     {
//         return price;
//     }
//
//     set
//     {
//         if (value >= 0)
//         {
//             price = value;
//         }
//         else
//         {
//             Console.WriteLine("Price cannot be negative!");
//         }
//     }
// }
//
// get
// -> gibt den gespeicherten Wert zurück
//
// set
// -> setzt einen neuen Wert
//
// value
// -> enthält automatisch den Wert,
//    der gerade zugewiesen werden soll
//
// Beispiel:
//
// Price = 30;
//
// Im Setter ist:
// value == 30


// ============================================
// KONSTRUKTOR
// ============================================

// Ein Konstruktor wird beim Erstellen eines
// neuen Objekts automatisch ausgeführt.
//
// Er trägt denselben Namen wie die Klasse.
//
// Beispiel:
//
// public Game(string title, int price, int age)
// {
//     Title = title;
//     Price = price;
//     Age = age;
// }
//
// Die Parameter:
// title
// price
// age
//
// bekommen beim Erstellen des Objekts ihre Werte.


// ============================================
// OBJEKT ERSTELLEN
// ============================================

// Beispiel:
//
// Game bendy = new Game("Bendy", 30, 16);
//
// Game
// -> Klasse / Datentyp
//
// bendy
// -> Variable für das Objekt
//
// new
// -> erstellt ein neues Objekt
//
// Game(...)
// -> ruft den Konstruktor auf
//
// "Bendy", 30, 16
// -> Werte für die Konstruktor-Parameter


// ============================================
// AUF EIN OBJEKT ZUGREIFEN
// ============================================

// Mit einem Punkt greift man auf Bestandteile
// eines Objekts zu.
//
// Beispiele:
//
// bendy.Title
// bendy.Price
// bendy.Age
//
// Methode aufrufen:
//
// bendy.ShowInfo();
// bendy.IsAllowed();


// ============================================
// METHODEN INNERHALB EINER KLASSE
// ============================================

// Klassen können eigene Methoden besitzen.
//
// Beispiel:
//
// public void ShowInfo()
// {
//     Console.WriteLine(
//         Title + " | Price: " + Price + " | Age: " + Age
//     );
// }
//
// Die Methode kann direkt auf Felder und
// Properties des jeweiligen Objekts zugreifen.


// ============================================
// MEHRERE OBJEKTE
// ============================================

// Aus derselben Klasse können beliebig viele
// verschiedene Objekte erstellt werden.
//
// Beispiel:
//
// Game bendy = new Game("Bendy", 30, 16);
// Game outlast = new Game("Outlast", 25, 18);
// Game minecraft = new Game("Minecraft", 20, 7);
//
// Jedes Objekt besitzt seine eigenen Werte.


// ============================================
// MERKSÄTZE
// ============================================

// class
// -> Bauplan für Objekte
//
// object
// -> konkretes Objekt einer Klasse
//
// new
// -> erstellt ein neues Objekt
//
// constructor
// -> richtet ein neues Objekt beim Erstellen ein
//
// public
// -> von außerhalb der Klasse erreichbar
//
// private
// -> nur innerhalb der Klasse erreichbar
//
// get
// -> Wert lesen
//
// set
// -> Wert setzen
//
// value
// -> neuer Wert innerhalb eines Setters
//
// Property
// -> kontrollierter Zugriff auf einen Wert
//
// Methode
// -> Verhalten / Aktion eines Objekts
//
// Punktzugriff:
// objekt.Property
// objekt.Methode()