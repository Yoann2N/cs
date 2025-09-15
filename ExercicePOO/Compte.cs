class Compte
{

    private decimal _solde = 0;
    public decimal Solde
    {
        get
        {
            return _solde;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Le solde ne peut pas être négatif.");
            }
            _solde = value;
        }
    }



    public Titulaire Titulaire { get; set; }
    public void Afficher()
    {
        Console.WriteLine($"--- Informations du Compte ---");
        Console.WriteLine($"Solde: {_solde} €");

        if (Titulaire != null)
        {
            Console.WriteLine("--- Informations du Titulaire ---");
            Console.WriteLine($"ID: {Titulaire.ID}");
            Console.WriteLine($"Nom: {Titulaire.Prenom} {Titulaire.Nom}");
            Console.WriteLine($"Adresse: {Titulaire.Adresse}, {Titulaire.CodePostal} {Titulaire.Ville}");
            Console.WriteLine($"Tel: {Titulaire.Tel}");
            Console.WriteLine($"Email: {Titulaire.Email}");
        }
        else
        {
            Console.WriteLine("Aucun titulaire associé à ce compte.");
        }
    }
}
class Titulaire
{
    private string _id;
    private string _nom;
    private string _prenom;
    private string _adresse;
    private string _codePostal;
    private string _ville;
    private string _tel;
    private string _email;
    public string ID
    {
        get
        { return _id; }
        set
        { _id = value; }
    }

    public string Nom
    {
        get
        { return _nom; }
        set
        { _nom = value; }
    }
    public string Prenom
    {
        get
        { return _prenom; }
        set
        { _prenom = value; }
    }
    public string Adresse
    {
        get
        { return _adresse; }
        set
        { _adresse = value; }
    }
    public string CodePostal
    {
        get
        { return _codePostal; }
        set
        { _codePostal = value; }
    }
    public string Ville
    {
        get
        { return _ville; }
        set
        { _ville = value; }
    }
    public string Tel
    {
        get
        { return _tel; }
        set
        { _tel = value; }
    }
    public string Email
    {
        get
        { return _email; }
        set
        { _email = value; }
    }

    public Titulaire(string id, string nom, string prenom, string adresse, string codePostal, string ville, string tel, string email, decimal solde)
    {
        _solde = solde;
        _titulaire = new Titulaire(id, nom, prenom, adresse, codePostal, ville, tel, email);
    }
}




