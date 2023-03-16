//Imprime números inpares ascendente

int c,s,n;
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime los numeros inpares de q a n, calcula la suma y el promedio, proceso se repite");
    Console.Write("Hasta que numero: "); n=int.Parse(Console.ReadLine());

    c= ( n%2==0 ? --n : n);
    s= 0;

    while( c <= n){
        Console.Write($"{c} ");
        s+=c;
        c+=1;
    }
    Console.WriteLine($"\n La suma es {s}");
    Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");