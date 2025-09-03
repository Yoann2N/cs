Console.WriteLine("Dire bonjour : 1");
Console.WriteLine("Dire au revoir: 2");
Console.WriteLine("Quitter : 3");
int choix = Convert.ToInt32(Console.ReadLine()!);

switch (choix)
{
    case 1:
        Console.WriteLine("Bonjour!");
        break;
    case 2:
        Console.WriteLine("Au revoir!");
        break;
    case 3:
        Console.WriteLine("Quitter le programme.");
        break;
    
}