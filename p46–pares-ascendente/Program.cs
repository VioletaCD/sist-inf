//Imprime números pares ascendente

int c,s,n;
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime los numeros pares de 2 a n, calcula la suma, el proceso se repite");
    Console.Write("Hasta que numero: "); n=int.Parse(Console.ReadLine());

    c= 2;
    s= 0;

    while( c <= n){
        Console.Write($"{c} ");
        s+=c;
        c+=2;
    }
    Console.WriteLine($"\n La suma es {s}");
    Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");