Random aleatoire = new Random();
int nbrMystere = aleatoire.Next(1, 100);
int nbrUtilisateur = -1;

do
{
    Console.Write("Devinez le nombre mystère : ");
    nbrUtilisateur = Convert.ToInt32(Console.ReadLine()!);

    if (nbrUtilisateur < nbrMystere)
    {
        Console.WriteLine("Le nombre mystère est plus grand");
    }
    else if (nbrUtilisateur > nbrMystere)
    {
        Console.WriteLine("Le nombre mystère est plus petit");
    }

} while (nbrUtilisateur != nbrMystere);

Console.WriteLine("Bravo, vous avez trouvé le nombre mystère !");