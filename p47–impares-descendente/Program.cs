//Imprime números impares de n a 1, calcula la suma, el proceso se repite

int c,s,n;
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime números impares de n a 1, calcula la suma, el proceso se repite");
    Console.Write("Desde que numero: "); n=int.Parse(Console.ReadLine());

    c=( n%2==0 ? --n : n);
    s= 0;

    while( c >= 1){
        Console.Write($"{c} ");
        s+=c;
        c-=2;
    }
    Console.WriteLine($"\n La suma es {s}");
    Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");