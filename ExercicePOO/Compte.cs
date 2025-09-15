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
        public void Afficher()
            {
                Console.WriteLine($"Solde: {_solde}");
            }

}

