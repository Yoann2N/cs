Console.WriteLine("entrer un chiffre : ");
int chiffre = Convert.ToInt32(Console.ReadLine()!);

for (int i = 0; i <= 10; i++)
{
    
    Console.WriteLine($"{chiffre} x {i} = {chiffre * i}");
}

