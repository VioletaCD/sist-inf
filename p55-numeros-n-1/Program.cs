// Imprimir los numeos desde n hasta 1

int n, p;
char resp;

do{
    Console.Clear();
    Console.Write("Hasta donde quieres llegar: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("A que paso: ");
    p = int.Parse(Console.ReadLine());

    for(int i=n; i>=1; i-=p) {
        Console.Write($"{i} ");
    }

    Console.WriteLine("\n Deseas continuar (S/N)");
    resp = char.ToUpper(Console.ReadLine() [0]);
}while(resp !='N');
Console.WriteLine("\n Proceso terminado..");
