// Calcula fuerza, masa, y aceleración de acuerdo a la segunda ley de newton

float f, m, a;

Console.Clear();

Console.WriteLine("Calcula fuerza, masa, y aceleración de acuerdo a la segunda ley de newton\n");

Console.WriteLine("[F]uerza         f=m*a");
Console.WriteLine("[M]asa           m=f/a");
Console.WriteLine("[A]celeracion    a=f/m");

Console.Write("Elije una opcion: ");
char op = char.ToUpper(Console.ReadLine()[0]);

f=m=a=0;

if( op=='F' ) {
    Console.WriteLine("\nCalculando la Fuerza ...");
    Console.Write("Ingrese la Masa: ");m = float.Parse(Console.ReadLine());
    Console.Write("Ingrese la Aceleracion: ");a = float.Parse(Console.ReadLine());
    f = m * a;
Console.WriteLine($"\nLa fuerza es: {f:f2}");
} else if( op=='M' ) {
Console.WriteLine("\nCalculando la Masa ...");
Console.Write("Ingrese la Fuerza: ");f = float.Parse(Console.ReadLine());
Console.Write("Ingrese la Aceleracion: ");a = float.Parse(Console.ReadLine());
m = f / a;
Console.WriteLine($"\nLa masa es: {m:f2}");
} else if( op=='A' ) {
Console.WriteLine("\nCalculando la Aceleracion ...");
Console.Write("Ingrese la Fuerza: ");f = float.Parse(Console.ReadLine());
Console.Write("Ingrese la Masa: ");m = float.Parse(Console.ReadLine());
a = f / m;
Console.WriteLine($"\nLa aceleración es: {a:f2}");
}
else Console.WriteLine("\nOPCION INVALIDA!! \n");

Console.WriteLine("\nPROCESO TERMINADO!! \n");