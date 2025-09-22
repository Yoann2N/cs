public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Utilisateur()
    {
        Nom = "";
        Prenom = "";
    }

    public Utilisateur(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }

    public void Afficher()
    {
        Console.WriteLine($"Utilisateur: {Nom}, Prénom: {Prenom}");
    }
}

public class Administrateur : Utilisateur
{
    
}

public class Client : Utilisateur
{
    public Client()
    {
        Adresse = "";
    }

    public Client(string prenom, string nom, string adresse)
    {
        Adresse = "";
    }

    public Client(string nom, string prenom, string adresse) : base(nom, prenom)
    {
        // Adresse = adresse;
        // Nom = nom;
        Prenom = prenom;
    }
    public string Adresse { get; set; }
    public new void Afficher()
    {
        Console.WriteLine($"Client: {Nom}, Prénom: {Prenom} Adresse: {Adresse}");
    }

}

public class Employe : Utilisateur
{
    public Employe()
    {
        Poste = "";
    }
    public string Poste { get; set; }
    public new void Afficher()
    {
        Console.WriteLine($"Employé: {Poste} {Nom}, Prénom: {Prenom}");
    }
}