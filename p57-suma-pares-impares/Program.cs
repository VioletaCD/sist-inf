// De 1 a n y de n a 1 y su suma
int n, op, suma,i;
do {
    suma=0;
    Console.Clear();
    Console.WriteLine("[ 1 ] --- Numeros pares de 1 a n");
    Console.WriteLine("[ 2 ] --- Numeros impares de n a 1");
    Console.WriteLine("[ 3 ] --- Salir");
    Console.Write("Elige: "); op=int.Parse(Console.ReadLine());
    switch(op) {
        case 1:
            Console.WriteLine("\nImprimiendo números pares de 1 a n");
            Console.Write("Hasta donde: "); n=int.Parse(Console.ReadLine());
            for(i=2; i<=n; i+=2){
                Console.Write($"{i} ");
                suma += i;
            }
            Console.WriteLine($"\nSuma de pares {suma}");
        break;
        case 2:
            Console.WriteLine("\nImprimiendo números impares de n a 1");
            Console.Write("Desde donde: "); n=int.Parse(Console.ReadLine());
            n = (n%2==0 ? --n: n);
            for(i=n; i>=1; i-=2){
                Console.Write($"{i} ");
                suma += i;
            }
            Console.WriteLine($"\nSuma de impares {suma}");
        break;
        case 3:
            Console.WriteLine("\nTe vas por que yo quiero que te vayas");break;
            default:
            Console.WriteLine("\nOpcion Invalida");
        break;
    }
    Console.WriteLine("\nPresiona cualquier tecla para continuar");
    Console.ReadLine();
} while( op != 3);
Console.WriteLine("\nProceso Terminado ....");