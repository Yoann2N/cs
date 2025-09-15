class Program
{
    public static void Main(string[] args)
    {
        Compte monCompte = new Compte("Doe", "John", "123 Rue Principale", "75001", "Paris", "0123456789", "Doejhon@gmail.com", 100.50m);
        monCompte.Solde = 150.75m; // Affectation du solde avec postfixe m
        monCompte.Solde = (decimal)150.75; // Affectation du solde explicite
        monCompte.Afficher(); // Affichage du solde

        Titulaire t1 = new Titulaire("Doe", "John", "123 Rue Principale", "75001", "Paris", "0123456789", "Doejhon@gmail.com");
        t1.Afficher();

        monCompte.Crediter(50.25m);
        monCompte.Debiter(30.00m);
       
       


    }
}