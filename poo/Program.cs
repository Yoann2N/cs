



class Program
{
    static void Main(string[] args)
    {
        // string Paris = "Paris";

        Console.WriteLine("Début");
        // instanciation d'un objet Ville
        Ville Avignon = new Ville("Avignon", "84000");

        Avignon.Nom = "Avignon";  // affectation de la propriété Nom
        Avignon.CodePostal = "84000"; // affectation de la propriété CodePostal

        // Utilisation de la méthode Afficher
        Avignon.Afficher();

        Console.WriteLine("Début");
        // instanciation d'un objet Ville
        Ville Marseille = new Ville("Marseille", "13000");

        Marseille.Nom = "Marseille";  // affectation de la propriété Nom
        Marseille.CodePostal = "13000"; // affectation de la propriété CodePostal

        // Utilisation de la méthode Afficher
        Marseille.Afficher();

        Ville Paris = new Ville("Paris");
        Paris.CodePostal = "75000"; // affectation de la propriété CodePostal
        Paris.Afficher();
        Paris.Population = 200000;
        Console.WriteLine(Paris.Population);
        // Paris.Bonjour();

        Ville.Bonjour();

        Console.WriteLine(Ville.region);


    }
}