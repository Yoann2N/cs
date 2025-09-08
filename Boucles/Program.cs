// for : Quand on sait à l'avance combien de fois on doit répéter une action
// While  : quand on ne sait pas à l'avance combien de fois on doit répéter une action
// Do While : variante de While, on exécute au moins une fois le bloc de code
// Foreach : pour parcourir une collection (tableau, liste, dictionnaire, ...)

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
    Console.WriteLine("Boucle for terminée");

int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}

Console.WriteLine("Boucle while terminée");

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 10);
Console.WriteLine("Boucle do while terminée");

int entier = 23;
int[] tableau = { 1, 2, 3, 4, 5, 6 };
foreach (int element in tableau) ;
{
    Console.WriteLine(element);
}
Console.WriteLine("Boucle foreach terminée");

string [] chaines = { "un", "deux", "trois" };
foreach (string chaine in chaines)
{
    Console.WriteLine(chaine);
}   
