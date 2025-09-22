class Ville
{

    public Ville(string nom, string codePostal)
    {
        Nom = nom;
        CodePostal = codePostal;
    }

    public Ville()
    {
        Nom = "";
        CodePostal = "";
    }

    public Ville(string nom)
    {
        Nom = nom;
        CodePostal = "";
    }

    // Attributs
    public string Nom { get; set; }
    public string CodePostal { get; set; }

    private int _population = 1000;

    public int Population
    {
        get
        {
            return _population;
        }
        set
        {
            
            if (value < 0)
            {
                throw new ArgumentException("La population ne peut pas être négative.");
            }
            else if (value > 1000000)
            {
                throw new ArgumentException("La population ne peut pas dépasser 1 000 000.");
            }
            _population = value;
        }
    }

    public static string region = "PACA";

    // Comportement de la classe : Méthode (fonctions)
    public void Afficher()
    {
        Console.WriteLine($"Ville: {this.Nom}, Code Postal: {this.CodePostal} {region}" );
        Test();
    }

    private void Test()
    {
        Console.WriteLine("Test");
    }
    
    public static void Bonjour()
    {
        Console.WriteLine($"Bonjour");
    }
    
}