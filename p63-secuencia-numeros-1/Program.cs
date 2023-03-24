// Imprime una pirámide de numeros

char resp;
do {
 int renglones;
        Console.Clear();
        Console.WriteLine("Ingresa el número de renglones de la pirámide:");
        renglones = int.Parse(Console.ReadLine());

        Console.WriteLine("Pirámide de números:");

        for (int i = 1; i <= renglones; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");