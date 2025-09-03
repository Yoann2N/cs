Console.WriteLine("Entrer votre âge :");
int age = Convert.ToInt32(Console.ReadLine()!);

if (age < 18) 
{
    Console.WriteLine("Vous êtes mineur.");
}
else
{
    Console.WriteLine("Vous êtes majeur.");
}
