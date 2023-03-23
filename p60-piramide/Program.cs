// Imprime una pirámide de asteriscos de n renglones

char resp;
do {
Console.Clear();
Console.Write("Cuantos renglones: "); int n = int.Parse(Console.ReadLine());
Console.Write("De que caracter: "); char car = Console.ReadLine()[0];

for(int i=1; i<=n; i++) {
    for(int j=1; j<=i; j++) {
     Console.Write($"{car} ");
    }
    Console.WriteLine("\r");
}
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");
