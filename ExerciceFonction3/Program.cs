int PlusGrand(int a, int b)
{
    if (a < b)
    {
        return b;
    }
    else
    {
        return a;
    }
}

Console.Write("Entrer un nombre : ");
int a = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Entrer un autre nombre : ");
int b = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"Le plus grand est : {PlusGrand(a, b)}");

