Console.WriteLine("Entrer un nombre 1: ");
int nombre1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Entrer un nombre 2: ");
int nombre2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Entrer un opérateur: ");
char op = Convert.ToChar(Console.ReadLine()!);

switch (op)
{
    case '+':
        Console.WriteLine("Résultat : " + (nombre1 + nombre2));
        break;
    case '-':
        Console.WriteLine("Résultat : " + (nombre1 - nombre2));
        break;
    case '*':
        Console.WriteLine("Résultat : " + (nombre1 * nombre2));
        break;
    case '/':
        Console.WriteLine("Résultat : " + (nombre1 / nombre2));
        break;
    default:
        Console.WriteLine("Opérateur invalide");
        break;
}