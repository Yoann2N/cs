// créer un tableau de 5 prenom et l'afficher 
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] prenoms = new string[5];

        // Remplir le tableau avec des prénoms
        for (int i = 0; i < prenoms.Length; i++)
        {
            Console.Write($"Entrez le prénom {i + 1}: ");
            prenoms[i] = Console.ReadLine();
        }

        // Afficher les prénoms
        Console.WriteLine("\nLes prénoms saisis sont:");
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }
    }
}