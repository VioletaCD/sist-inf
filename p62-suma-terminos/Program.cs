// suma de terminos de 1 / n!

int f,r;
char resp;
do {

    Console.Clear();
    Console.Write("Hasta que número: "); int n = int.Parse(Console.ReadLine());

        r=0;
        for(int j=1; j<=n; j++) {
            Console.Write($"1 / {j}! ");
            if(j!=n)
                Console.Write(" + ");
            f=1;
            for(int i=1; i<=j; i++) {
                f *= i;
                r += ( 1 / f);
        }
        Console.WriteLine($" = {r}");
    }
    Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ...");

