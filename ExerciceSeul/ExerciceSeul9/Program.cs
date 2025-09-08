Console.WriteLine("Entrer une note entre 0 et 20 :");
int note = Convert.ToInt32(Console.ReadLine()!);

switch (note)
{
    case int n when(note <= 9):
        Console.WriteLine("Insuffisant");
        break;
    case int when(note >= 10 && note <= 13):
        Console.WriteLine("Moyen");
        break;
    case int when(note >= 14 && note <= 16):
        Console.WriteLine("Bien");
        break;
    case int when(note >= 17 && note <= 20):
        Console.WriteLine("Excellent");
        break;
}