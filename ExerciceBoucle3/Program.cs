int nombre = 1;
while (nombre != 0)
{
    Console.WriteLine(" Entrer un nombre : ");
    nombre = Convert.ToInt32(Console.ReadLine()!);
}
if (nombre == 0)
{
    Console.WriteLine(" Fin du programme ");
}
