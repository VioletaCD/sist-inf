
        int opcion;
        int inicio, fin, constante;

        do {
            Console.Clear(); 

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Suma de números múltiplos de 3");
            Console.WriteLine("2. Suma de números múltiplos de 4");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Elige una opción:");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.WriteLine("Introduce el inicio del rango:");
                    inicio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el fin del rango:");
                    fin = int.Parse(Console.ReadLine());

                    constante = 3;

                    int resultadoMultiplos3 = SumaMultiplos(inicio, fin, constante);
                    Console.WriteLine("Los números múltiplos de " + constante + " en el rango de " + inicio + " a " + fin + " son:");
                    for (int i = inicio; i <= fin; i++) {
                        if (i % constante == 0) {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("La suma de los números múltiplos de " + constante + " en el rango de " + inicio + " a " + fin + " es " + resultadoMultiplos3 + ".");
                    break;
                case 2:
                    Console.WriteLine("Introduce el inicio del rango:");
                    inicio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el fin del rango:");
                    fin = int.Parse(Console.ReadLine());

                    constante = 4;

                    int resultadoMultiplos4 = SumaMultiplos(inicio, fin, constante);
                    Console.WriteLine("Los números múltiplos de " + constante + " en el rango de " + inicio + " a " + fin + " son:");
                    for (int i = inicio; i <= fin; i++) {
                        if (i % constante == 0) {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("La suma de los números múltiplos de " + constante + " en el rango de " + inicio + " a " + fin + " es " + resultadoMultiplos4 + ".");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Introduce una opción válida.");
                    break;
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadLine();
        } while (opcion != 3);
    
    int SumaMultiplos(int inicio, int fin, int constante) {
    
        int suma = 0;

        for (int i = inicio; i <= fin; i++) {
            if (i % constante == 0) {
                suma += i;
            }
        }

        return suma;
    }

