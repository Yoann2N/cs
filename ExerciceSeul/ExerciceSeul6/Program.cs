Console.WriteLine("Entrer un nombre 1: ");
int Nombre1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Entrer un nombre 2: ");
int Nombre2 = Convert.ToInt32(Console.ReadLine()!);

if (Nombre1 < Nombre2)
{
    Console.WriteLine("Le nombre 1 est plus petit que le nombre 2");
}
else if (Nombre1 > Nombre2)
{
    Console.WriteLine("Le nombre 1 est plus grand que le nombre 2");
}
else
{
    Console.WriteLine("Les deux nombres sont égaux");
}