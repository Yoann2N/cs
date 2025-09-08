int carré (int a)
{
    return a * a;
}
Console.WriteLine("Entrer un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Le carré de {nombre} est {carré(nombre)}");