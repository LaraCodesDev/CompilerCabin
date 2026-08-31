// OOP - Object-Oriented Programming
// ==================================


// 1. CLASS RESPONSIBILITIES
// -------------------------
// A class should have a clear responsibility.
//
// Example:
// CombatPlayer -> player data, health, taking damage
// Weapon       -> weapon data and attacking
//
// Things that belong together stay together.
// Different responsibilities should be separated.


// 2. OBJECTS INSIDE OTHER OBJECTS
// -------------------------------
// An object can contain another object.
//
// Example:
//
// class CombatPlayer
// {
//     Weapon weapon;
// }
//
// The CombatPlayer HAS a Weapon.


// 3. CONSTRUCTOR WITH AN OBJECT
// ----------------------------
// Objects can also be passed into a constructor.
//
// Example:
//
// public CombatPlayer(string name, int health, Weapon weapon)
// {
//     this.name = name;
//     this.health = health;
//     this.weapon = weapon;
// }
//
// "this.weapon" = field of the CombatPlayer
// "weapon"      = parameter passed into the constructor


// 4. OBJECT COMPOSITION
// ---------------------
// Combining objects like this is called composition.
//
// Example:
//
// Weapon weapon = new Weapon("Sword", 25);
//
// CombatPlayer player =
//     new CombatPlayer("Lara", 100, weapon);
//
// The Weapon exists as its own object.
// The CombatPlayer receives and uses that Weapon.


// 5. OBJECTS INTERACTING
// ----------------------
// One object can call a method of another object.
//
// Example:
//
// public void Attack()
// {
//     weapon.Attack();
// }
//
// CombatPlayer does not need to handle the weapon's
// attack logic itself.
//
// It tells its Weapon to attack.


// 6. METHODS AND RESPONSIBILITIES
// -------------------------------
// A method should usually be placed in the class
// that is responsible for that behaviour.
//
// Example:
//
// CombatPlayer:
// TakeDamage()
//
// Weapon:
// Attack()
//
// This keeps the code separated and easier to understand.


// 7. USING THE OBJECT
// -------------------
//
// Weapon weapon = new Weapon("Sword", 25);
// CombatPlayer player = new CombatPlayer("Lara", 100, weapon);
//
// player.TakeDamage(25);
// player.Attack();
//
//
// Flow:
//
// player.Attack()
//      ↓
// CombatPlayer.Attack()
//      ↓
// weapon.Attack()