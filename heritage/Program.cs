namespace Heritage
{
    public class Heritage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
}

public class Utilisateur
{
    public static void Main(string[] args)
    {
        Utilisateur user = new Utilisateur();
        user.Nom = "Dupont";
        user.Prenom = "Jean";
        user.Afficher();
    }
    
}