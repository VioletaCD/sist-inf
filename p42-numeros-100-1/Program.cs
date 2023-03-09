// Imprime los números del 100 - 1

Console.Clear();

int c,n,p;

Console.Write("Hasta donde quieres llegar: ");
n = int.Parse(Console.ReadLine());
Console.Write("De cuanto en cuanto hay que avanzar: ");
p = int.Parse(Console.ReadLine());

c=n;

while( c >= 1 ) {
Console.Write(c+" ");
c-=p;
}
Console.WriteLine("\n PROCESO TERMINADO");
