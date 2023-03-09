// Imprime los números del 1 - 100

Console.Clear();

int c,n,p;

c=0;

Console.Write("Hasta donde quieres llegar: ");
n = int.Parse(Console.ReadLine());
Console.Write("De cuanto en cuanto hay que avanzar: ");
p = int.Parse(Console.ReadLine());

while( c <= n ) {
Console.Write(c+" ");
c+=p;
}
Console.WriteLine("\n PROCESO TERMINADO");
