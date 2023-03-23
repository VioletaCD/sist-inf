// Tablas de multiplicar del 1 al 10 iniciando en 1 y hasta 10

char resp;
do {
Console.Clear();
Console.Write("Hasta cual tabla: "); int n = int.Parse(Console.ReadLine());
Console.Write("Hasta donde: "); int m = int.Parse(Console.ReadLine());

for(int i=1; i<=10; i++){
    Console.WriteLine($"Tabla del {i}");
    for(int j=1; j<=10; j++)
        Console.WriteLine($"{i} x {j} = {i*j}");
    Console.WriteLine("\n");
}
Console.WriteLine("\nDeseas continuar (S/N) ?");
resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ...");