// 8. CUSTOM OBJECTS IN LISTS
// --------------------------

// A List can store objects of our own classes,
// not only basic types like string or int.
//
// Example:
//
// List<Item> items = new List<Item>();
//
// List<string> -> stores strings
// List<Item>   -> stores Item objects


// 9. CLASS TYPE AND VARIABLE NAME
// -------------------------------

// Example:
//
// Item item = new Item("Potion", 50);
//
// Item
// -> class / type
//
// item
// -> variable that references the object
//
// new Item("Potion", 50)
// -> creates a new Item object
//
// The same pattern also works with other classes:
//
// Weapon weapon = new Weapon("Sword", 25);
//
// Weapon -> class / type
// weapon -> variable


// 10. PASSING OBJECTS TO METHODS
// ------------------------------

// Objects can be passed to methods as parameters.
//
// Example:
//
// public void PickUpItem(Item item)
// {
//     inventory.AddItem(item);
// }
//
// "Item" = type of object the method expects
// "item" = parameter containing the object
//
// The same object can then be passed to another method:
//
// inventory.AddItem(item);


// 11. ACCESSING OBJECT PROPERTIES
// -------------------------------

// An object can contain multiple properties.
//
// Example:
//
// public string Name { get; set; }
// public int Value { get; set; }
//
// When we have an Item object:
//
// Item item = new Item("Potion", 50);
//
// we can access its properties with a dot:
//
// item.Name
// item.Value
//
// Example with a List:
//
// foreach (Item item in items)
// {
//     Console.WriteLine($"{item.Name} - {item.Value}");
// }
//
// "items" = the whole List<Item>
// "item"  = one Item object from the list
// ".Name" and ".Value" = properties of that object