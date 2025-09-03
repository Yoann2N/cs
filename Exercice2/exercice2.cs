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

bool estplusjeune = pierre < paul;
switch (pierre<paul)
{
    case true:

        Console.WriteLine("Pierre est plus jeune que Paul");
        break;
    case false:
        Console.WriteLine("Pierre est plus âgé que Paul");
        break;
    default:
        Console.WriteLine("Pierre et Paul ont le même âge");
        break;  
}