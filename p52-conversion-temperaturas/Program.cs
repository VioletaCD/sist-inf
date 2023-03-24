// Imprime tabla de conversión de temperaturas

double inicial, final;
char resp;

do{
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de temperatura Celciuis a Fahrenheit\n");


        Console.WriteLine("Introduce la temperatura inicial en grados centígrados:");
        inicial = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce la temperatura final en grados centígrados:");
        final = double.Parse(Console.ReadLine());

        if (final < inicial)
        {
            Console.WriteLine("Error: La temperatura final no puede ser menor a la temperatura inicial.");
        }
        else
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine("Celsius | Fahrenheit:");
            Console.WriteLine(new string('-',40));

            double celsius = inicial;
            while (celsius <= final)
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine(celsius + "°C    | " + fahrenheit + "°F");
                celsius++;
            }
        }

 Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");