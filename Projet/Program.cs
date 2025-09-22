using System;
using ExempleObjet;

namespace ExempleObjet
{
    // Définition d'une classe Ville 
    public class Ville
    {
        // Données de la classe : Propriété / Attribut
        public string Nom { get; set; }
        public string CodePostal { get; set; }

        // Comportement de la classe : Méthode (fonctions)
        public void Afficher()
        { 
            Console.WriteLine($"Ville: {Nom}, Code Postal: {CodePostal}");
        }
    }
    {
        // Attributs
        public string Nom { get; set; }
        public int Population { get; set; }

        // Constructeur
        public Ville(string nom, int population)
        {
            Nom = nom;
            Population = population;
        }

        // Méthode d'instance
        public void AfficherInfo()
        {
            Console.WriteLine($"Ville: {Nom}, Population: {Population}");
        }
    }
    // Définition d'une classe Personne
    public class Personne
    {
        // Attributs
        public string Nom { get; set; }
        public int Age { get; set; }

        // Constructeur
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        // Méthode d'instance
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m'appelle {Nom} et j'ai {Age} ans.");
        }
    }

    // Classe principale avec Main
    class Program
    {
        static void Main(string[] args)
        {

            Ville Ville = new Ville();
            string AutreVille;


            // Création d’un objet Personne
        Personne alice = new Personne("Alice", 25);

            // Appel d’une méthode de l’objet
            alice.SePresenter();

            // On peut créer un autre objet
            Personne bob = new Personne("Bob", 30);
            bob.SePresenter();
        }
    }
}