int note = 15;
if (note >= 10)
{
    Console.WriteLine("Admis");
}
else
{
    Console.WriteLine("Non admis");
}


if (note >= 10)
    Console.WriteLine("Admis");
else
    Console.WriteLine("Non admis");

    for (int i = 0; i <= 10; i++)
    
        Console.WriteLine(i);


switch (note)
{
    case >= 15:
        Console.WriteLine("Très bien");
        break;
    case >= 10:
        Console.WriteLine("Bien");
        break;
    case >= 5:
        Console.WriteLine("Passable");
        break;
    default:
        Console.WriteLine("Mauvais");
        break;
}
        
int pierre = 25;
int paul = 30;

if (pierre < paul) 
    Console.WriteLine("Pierre est plus jeune que Paul");

else if (pierre > paul) 
    Console.WriteLine("Pierre est plus âgé que Paul");

else 
    Console.WriteLine("Pierre et Paul ont le même âge");


switch (pierre < paul)
{
    case true:
        Console.WriteLine("Pierre est plus jeune que Paul");
        break;
    case false:
        if (pierre > paul)
            Console.WriteLine("Pierre est plus âgé que Paul");
        else
            Console.WriteLine("Pierre et Paul ont le même âge");
        break;
}