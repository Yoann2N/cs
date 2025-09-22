namespace Heritage
{
    public class Heritage
    {
        public static void Main(string[] args)
        {
            // Utilisateur user = new Utilisateur();
            // user.Nom = "Dupont";
            // user.Prenom = "Jean";
            // user.Afficher();

            Utilisateur user = new Utilisateur("Dupont", "Jean");
            user.Afficher();

            // Client client = new Client();
            // client.Adresse = " Place Jean Jaurès 84740 Velleron";
            // client.Nom = "Durand";
            // client.Prenom = "Paul";

            Client client = new Client("Durand", "Paul", " Place Jean Jaurès 84740 Velleron");
            client.Afficher();

            Employe employe = new Employe();
            employe.Poste = " Secrétaire";
            employe.Nom = "Durand";
            employe.Prenom = "Paul";
            employe.Afficher();
        }

    }
}

