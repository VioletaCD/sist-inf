// Imprimir el factorial de los números de 1 a n

int f;
char resp;
do {

    Console.Clear();
    Console.Write("Hasta que número: "); int n = int.Parse(Console.ReadLine());

        for(int j=1; j<=n; j++) {
            Console.Write($"{j}!=");
                f=1;
            for(int i=1; i<=j; i++) {
                Console.Write($"{i}");
                if(i! = j)
                    Console.Write(" x ");
                f *= i;
        }
        Console.WriteLinen
        ($" = {f}");
    }
    Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ...");