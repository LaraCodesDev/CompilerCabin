//CharacterLoader.Run();
/*Weapon weapon = new Weapon("Sword", 25);
Inventory inventory = new Inventory();
CombatPlayer player = new CombatPlayer("Lara", 100, weapon, inventory);
player.TakeDamage(100);
player.Attack();
Item potion = new Item("Potion", 50);
Item key = new Item("Key", 10);
player.PickUpItem(potion);
player.PickUpItem(key);
player.ShowInventory();

PhotoAlbum photoAlbum = new PhotoAlbum("Hochzeit");
photoAlbum.AddPhoto("familie.jpg");
photoAlbum.AddPhoto("torte.jpg");
photoAlbum.AddPhoto("party.jpg");
photoAlbum.ShowPhotos();
Console.WriteLine(photoAlbum.GetPhotoCount());*/

PhotoSorter photoSorter = new PhotoSorter(@"L:\TestBilder");
photoSorter.ShowFiles();