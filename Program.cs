using Text_based_adventure.RogueClass;
using Text_based_adventure.MageClass;
using Text_based_adventure.WarriorClass;

Console.WriteLine("Welcome adventurer");
Console.WriteLine("You wake up and find 3 items in front of you, which do you pick up first?");
Console.WriteLine("1: A black blade shrouded in smoke and a rune on its handle (Rogue Class)");
Console.WriteLine("2: A longsword accompanied by a large shield. It looks heavy but makes you feel safe.(Warrior Class)");
Console.WriteLine("3: A staff humming with magical energy and a large crystal at the top, that looks like there is a small storm inside it (Mage Class)");
Console.WriteLine("Please choose from 1-3");

int classChoice = Convert.ToInt32(Console.ReadLine());

switch (classChoice)
{
    case 1:
        Rogue Roguestats = new Rogue();
        Console.WriteLine("You picked the Rogue class!");
        Console.WriteLine($"Here are your stats:");
        Console.WriteLine($"Health: {Roguestats.health}");
        Console.WriteLine($"Stamina: {Roguestats.stamina}");
        Console.WriteLine($"Intelligence: {Roguestats.intelligence}");
        Console.WriteLine($"Strength: {Roguestats.strength}");
        Console.WriteLine($"Dexterity: {Roguestats.dexterity}");
        Console.WriteLine($"Stealth: {Roguestats.stealth}");
        Console.WriteLine($"Damage: {Roguestats.baseDamage}");
        Console.WriteLine($"Armour: {Roguestats.armour}");
        Console.WriteLine($"Mana: {Roguestats.mana}");
        break;
    case 2:
        Mage MageStats = new Mage();
        Console.WriteLine("You picked the Mage class!");
        Console.WriteLine($"Here are your stats:");
        Console.WriteLine($"Health: {MageStats.health}");
        Console.WriteLine($"Stamina: {MageStats.stamina}");
        Console.WriteLine($"Intelligence: {MageStats.intelligence}");
        Console.WriteLine($"Strength: {MageStats.strength}");
        Console.WriteLine($"Dexterity: {MageStats.dexterity}");
        Console.WriteLine($"Stealth: {MageStats.stealth}");
        Console.WriteLine($"Damage: {MageStats.baseDamage}");
        Console.WriteLine($"Armour: {MageStats.armour}");
        Console.WriteLine($"Mana: {MageStats.mana}");
        break;
    case 3:
        Warrior WarriorStats = new Warrior();
        Console.WriteLine("You picked the Warrior class!");
        Console.WriteLine($"Here are your stats:");
        Console.WriteLine($"Health: {WarriorStats.health}");
        Console.WriteLine($"Stamina: {WarriorStats.stamina}");
        Console.WriteLine($"Intelligence: {WarriorStats.intelligence}");
        Console.WriteLine($"Strength: {WarriorStats.strength}");
        Console.WriteLine($"Dexterity: {WarriorStats.dexterity}");
        Console.WriteLine($"Stealth: {WarriorStats.stealth}");
        Console.WriteLine($"Damage: {WarriorStats.baseDamage}");
        Console.WriteLine($"Armour: {WarriorStats.armour}");
        Console.WriteLine($"Mana: {WarriorStats.mana}");
        break;
}

int userClass = classChoice;

string dialogue = userClass switch
{
    1 => "You pick up the blade and suddenly feel light on your feet.",
    2 => "You pick up the Staff and feel an enourmous amount of energy flowing through you.",
    3 => "You pick up the sword and shield, you feel stronger and its as if nothing could penetrate your skin."
};

Console.WriteLine(dialogue);



