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
    public Compte(string Nom, string Prenom, string Adresse, string CodePostal, string Ville, string Tel, string Email, decimal Solde)
    {
        _solde = Solde;
        Titulaire = new Titulaire(Nom, Prenom, Adresse, CodePostal, Ville, Tel, Email);
    }
    
    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant à créditer doit être positif.");
        }
        _solde += montant;
        Console.WriteLine($"Crédit de {montant} €. Nouveau solde: {_solde} €");
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant à débiter doit être positif.");
        }
        if (montant > _solde)
        {
            throw new InvalidOperationException("Fonds insuffisants pour ce débit.");
        }
        _solde -= montant;
        Console.WriteLine($"Débit de {montant} €. Nouveau solde: {_solde} €");
    }

    



   
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





