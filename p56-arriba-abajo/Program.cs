﻿// De 1 a n y de n a 1, según el usuario lo decida
int n, op;
do {
    Console.Clear();
    Console.WriteLine("[ 1 ] --- Numeros de 1 a n");
    Console.WriteLine("[ 2 ] --- Numeros de n a 1");
    Console.WriteLine("[ 3 ] --- Salir");
    Console.Write("Elige: "); op=int.Parse(Console.ReadLine());
    switch(op) {
        case 1:
            Console.Write("Hasta donde: "); n=int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            Console.Write($"{i} ");
        break;
        case 2:
            Console.Write("Desde donde: "); n=int.Parse(Console.ReadLine());
            for(int i=n; i>=1; i--)
            Console.Write($"{i} ");
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