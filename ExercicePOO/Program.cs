class Program
{
    public static void Main(string[] args)
    {
        Compte monCompte = new Compte();
        monCompte.Solde = 150.75m; // Affectation du solde avec postfixe m
        monCompte.Solde = (decimal)150.75; // Affectation du solde explicite
        monCompte.Afficher(); // Affichage du solde

        Titulaire titulaire = new Titulaire("1", "Doe", "John", "123 Rue Principale", "75001", "Paris", "0123456789", "Doejhon@gmail.com");
       
       


    }
}