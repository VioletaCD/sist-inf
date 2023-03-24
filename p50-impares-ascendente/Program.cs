//Imprime números impares de 1 a n, calcula el promedio, el proceso se repite

int c,s,n;
float p;
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime números impares de 1 a n, calcula el promedio, el proceso se repite");
    Console.Write("Hasta que numero: "); n=int.Parse(Console.ReadLine());

    p=0;
    c=1;
    s= 0;
    int i=0;

    while( c <= n){
       Console.Write($"{c} ");
        s+=c;
        c+=2;
        i++;
        p=s/i;
    
    }
   Console.WriteLine($"\n La suma es {s}");
   Console.WriteLine($"El promedio es {p}");
   
    Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");