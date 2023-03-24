// a imprimir la secuencia de términos armónicos el número de renglones que el usuario desee y su suma

char resp;
do {
        Console.Clear();  
        Console.Write("Ingrese la cantidad de números en la secuencia: ");
        int cantidad = int.Parse(Console.ReadLine());

        int numero = 1;
        int suma = 0;

        for (int i = 0; i < cantidad; i++) {
            Console.Write(numero);
            suma += numero;

            if (i < cantidad - 1) {
                Console.Write("+");
            }

            numero = numero * 10 + 1;
        }

        Console.WriteLine("\nLa suma de la secuencia es: " + suma);

Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");	
