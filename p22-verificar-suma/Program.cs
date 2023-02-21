// Verifica si la suma de dos numeros es igual a un tercero

int n1, n2, n3;

Console.Clear();

Console.WriteLine("Verificar si la suma de dos numeros es igual a un tercero\n");

Console.Write("Dame un numero: "); n1=int.Parse(Console.ReadLine());
Console.Write("Dame un seguno numero: "); n2=int.Parse(Console.ReadLine());
Console.Write("Dame un tercer numero: "); n3=int.Parse(Console.ReadLine());

if( n1+n2 == n3 )
Console.WriteLine("Son iguales");
else
Console.WriteLine("Son distintos");
Console.WriteLine("\nGracias por utilizar este programa!!");