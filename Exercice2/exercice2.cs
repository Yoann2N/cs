int pierre = 25;
int paul = 30;

if (pierre < paul) ;
{
    Console.WrriteLine("Pierre est plus jeune que Paul");
}
else if (pierre > paul) ;
{
    Console.WriteLine("Pierre est plus âgé que Paul");
}
else ;
{
    Console.WriteLine("Pierre et Paul ont le même âge");
}

switch (pierre)
{
    case < paul:
        Console.WriteLine("Pierre est plus jeune que Paul");
        break;
    case > paul:
        Console.WriteLine("Pierre est plus âgé que Paul");
        break;
    default: 
        Console.Writeline("Pierre et Paul ont le même âge");
        break;
}