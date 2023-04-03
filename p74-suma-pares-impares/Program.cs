int ImprimirPares(int inicio, int fin) {
    int suma=0;
        Console.WriteLine("Números pares en el rango [{0}, {1}]:", inicio, fin);
        
        for (int i = inicio; i <= fin; i++) {
            if (i % 2 == 0) {
                Console.WriteLine(i);
                suma+=i; 
            }
        }

        return suma;
    }

int ImprimirImpares(int inicio, int fin) {
        Console.WriteLine("Números impares en el rango [{0}, {1}]:", inicio, fin);
        int suma=0;
        
        for (int i = inicio; i <= fin; i++) {
            if (i % 2 != 0) {
                Console.WriteLine(i);
                suma+=i; 
            }
        }
        return suma;
    }

       int inicio, fin,suma;
       char resp;
    do {
        suma=0;
        Console.Clear();
        Console.Write("Ingrese el inicio del rango: ");
        inicio = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el fin del rango: ");
        fin = int.Parse(Console.ReadLine());
    
        Console.WriteLine("¿Qué desea imprimir?");
        Console.WriteLine("P: Pares");
        Console.WriteLine("I: Impares");
        
        string opcion = Console.ReadLine();
        
        switch (opcion.ToUpper()) {
            case "P":
                //ImprimirPares(inicio, fin);
                suma=ImprimirPares(inicio, fin);
                Console.Write($"\nLa suma es {suma}");
                break;
            case "I":
                //ImprimirImpares(inicio, fin);
                suma= ImprimirImpares(inicio, fin);
                Console.Write($"\nLa suma es {suma}");
                break;
            default:
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                break;
        }
        
    Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ...");