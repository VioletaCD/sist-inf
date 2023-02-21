//verifica si un numero es positivo negaivo o 0

int n;

Console.Clear();
Console.WriteLine("verifica si un numero es positivo negaivo o cero \n");
Console.WriteLine("Dame un numero: ");
n=int.Parse(Console.ReadLine());

if(n>0) Console.WriteLine("El numero es positivo...");
if(n<0) Console.WriteLine("El numero es negativo...");
if(n==0) Console.WriteLine("El numero es cero...");

Console.WriteLine("\nGracias por utilizar este super programa!!");
