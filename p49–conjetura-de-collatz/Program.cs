// Imprime la conjetura de collatz para un número entero positivo

long n;
char resp;

do{

Console.Clear();
do{Console.Write("Entero positivo: "); n= int.Parse(Console.ReadLine());} while(n<0);

while(n!=1){
    Console.Write($"{n} ");
    if(n%2==0)
        n = n /2;
    else
        n = 3 * n + 1;
}
Console.WriteLine(n);
 Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");