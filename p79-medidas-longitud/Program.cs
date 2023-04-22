// Programa con dos funciones una que convierta pulgadas a centímetros y otra que convierta de metros a pies.

        int opcion;
        double medida;

        do {
            Console.Clear(); 

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Convertir pulgadas a centimetros");
            Console.WriteLine("2. Convertir metros a pies");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Elige una opción:");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.WriteLine("Introduce la medida en pulgadas:");
                    medida = double.Parse(Console.ReadLine());

                    double resultadoPulgadas = ConvertirPulgadasACentimetros(medida);
                    Console.WriteLine(medida + " pulgadas equivalen a " + resultadoPulgadas + " centímetros.");
                    break;
                case 2:
                    Console.WriteLine("Introduce la medida en metros:");
                    medida = double.Parse(Console.ReadLine());

                    double resultadoMetros = ConvertirMetrosAPies(medida);
                    Console.WriteLine(medida + " metros equivalen a " + resultadoMetros + " pies.");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Introduce una opción válida.");
                    break;
            }

            Console.WriteLine("\n---Presiona cualquier tecla para continuar...---");
            Console.ReadLine();
        } while (opcion != 3);

    double ConvertirPulgadasACentimetros(double pulgadas) {
        double centimetros = pulgadas * 2.54;
        return centimetros;
    }

    double ConvertirMetrosAPies(double metros) {
        double pies = metros * 3.281;
        return pies;
    }

