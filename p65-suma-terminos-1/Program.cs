// a imprimir la secuencia de términos armónicos el número de renglones que el usuario desee y su suma

int n;
double suma = 0.0;
char resp;
do {
  
            Console.Clear();
            Console.WriteLine("Ingrese el número de renglones que desea imprimir:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double termino = 1.0 / i;
                suma += termino;
                Console.Write($"{termino:f} ");
                if(i!=n)//para no imprimir el ultimo asterisco
                Console.Write("+");
            }

            Console.WriteLine($"\nLa suma de los términos es: {suma}");

Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");	