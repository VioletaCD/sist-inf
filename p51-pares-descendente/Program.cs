//Imprime los numeros pares desde n a 2, calcula el promedio, el proceso se repite

int c,s,n;
char resp;
float p;
do{
    Console.Clear();
    Console.WriteLine("Imprime los numeros pares desde 100 a n, calcula el promedio, el proceso se repite");
    Console.Write("Hasta que numero: "); n=int.Parse(Console.ReadLine());

    c=100;
    s= 0;
    p= 0;

    while( c >= n){
        Console.Write($"{c} ");
        s+=c;
        p= (s/(s/n));
        c-=2;
    }
    Console.WriteLine($"\n La suma es {s}");
    Console.WriteLine($"El promedio es {p}");
    Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");