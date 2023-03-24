//Imprime serie de Fibonacci hasta n

int repeticiones;
        int a = 0, b = 1;

  char resp;

do{
    Console.Clear();
    Console.WriteLine("Imprime serie de Fibonacci hasta n\n");


              Console.WriteLine("Ingresa el número maximo:");
        repeticiones = int.Parse(Console.ReadLine());

        Console.WriteLine("Los primeros " + repeticiones + " números de la secuencia de Fibonacci son:");

        int contador = 0;
        while (contador < repeticiones)
        {
            Console.Write(a + " ");

            int auxiliar = a + b;
            a = b;
            b = auxiliar;

            contador++;
        }

 Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");