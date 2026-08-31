//CharacterLoader.Run();
Weapon weapon = new Weapon("Sword", 25);
CombatPlayer player = new CombatPlayer("Lara", 100, weapon);
player.TakeDamage(100);
player.Attack();