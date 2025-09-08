int a = 5;
int b = 10;

int somme = a + b;
Console.WriteLine("La somme de " + a + " et " + b + " est : " + somme);

int difference;
if (a > b)
    difference = a - b;
else
    difference = b - a;
Console.WriteLine("La différence entre " + a + " et " + b + " est : " + difference);

int produit = a * b;
Console.WriteLine("Le produit de " + a + " et " + b + " est : " + produit);

int quotient, reste;
if (a < b)
{
    quotient = b / a;
    reste = b % a;
}
else
{
    quotient = a / b;
    reste = a % b;
}

Console.WriteLine("Le quotient est : " + quotient);
Console.WriteLine("Le reste est : " + reste);

