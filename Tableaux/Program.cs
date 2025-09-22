// créer un tableau de 5 prenom et l'afficher 
using System;
class Program
{
    static void Main(string[] args)
    {
        // string[] prenoms = new string[5];

        // // Remplir le tableau avec des prénoms
        // for (int i = 0; i < prenoms.Length; i++)
        // {
        //     Console.Write($"Entrez le prénom {i + 1}: ");
        //     prenoms[i] = Console.ReadLine();
        // }

        // // Afficher les prénoms
        // Console.WriteLine("\nLes prénoms saisis sont:");
        // foreach (string prenom in prenoms)
        // {
        //     Console.WriteLine(prenom);
        // }

        List<string> listePrenoms = new List<string>() { "Jean", "Marie", "Pierre", "Luc", "Sophie" };
        foreach (string prenom in listePrenoms)
        {
            Console.WriteLine(prenom);
        }

        listePrenoms.Add("Paul");
        listePrenoms.Add("alice");

        listePrenoms.Remove("Jean");
        listePrenoms.Remove("Marie");

        Console.WriteLine("\nListe après modifications:");
        foreach (string prenom in listePrenoms)
        {
            Console.WriteLine(prenom);
        }

        listePrenoms.Sort();
        Console.WriteLine("\nListe après tri:");
        foreach (string prenom in listePrenoms)
        {
            Console.WriteLine(prenom);
        }
    }
}