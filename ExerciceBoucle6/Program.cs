 int[] nombres = { 3, 7, 2, 9, 4 };
        int somme = 0;

        foreach (int n in nombres)
        {
            somme += n;
        }

        Console.WriteLine($"La somme des éléments du tableau est : {somme}");