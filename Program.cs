using static Text_based_adventure.RogueClass.RogueClassStats;

Console.WriteLine("Welcome adventurer");
Console.WriteLine("You wake up and find 3 items in front of you, which do you pick up first?");
Console.WriteLine("1: A black blade shrouded in smoke and a rune on its handle (Rogue Class)");
Console.WriteLine("2: A longsword accompanied by a large shield. It looks heavy but makes you feel safe.(Warrior Class)");
Console.WriteLine("3: A staff humming with magical energy and a large crystal at the top, that looks like there is a small storm inside it (Mage Class)");
Console.WriteLine("Please choose from 1-3");

int classChoice = Convert.ToInt32(Console.ReadLine());

if (classChoice == 1)
{
    Console.WriteLine("You picked the Rogue class!");
    Console.WriteLine($"Here are your stats: {RogueClassStats}");
}
