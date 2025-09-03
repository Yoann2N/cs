Console.WriteLine("Entrer un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine()!);

if (nombre % 2 == 0)
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("Le nombre est impair");
}