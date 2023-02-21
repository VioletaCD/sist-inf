// Convertir temperatura de grados celcius a farenheit y viceversa

char op;
float temp, res;

Console.Clear();
Console.WriteLine("Convertir de grados celcius a farenheit y viceversa\n");

Console.WriteLine("[F]arenheit a Centigrados ");
Console.WriteLine("[C]entigrados a Farenheit ");
Console.Write("Elije una opcion: ");
op = char.ToUpper(Console.ReadLine()[0]);

if( op=='F' ) {
Console.WriteLine("\nConvertir a Farenheit..\n");

Console.Write("Ingrese los grados en Celcius: "); temp=float.Parse(Console.ReadLine());
res = ( temp * 9 / 5 ) + 32;

Console.WriteLine($"{temp} Celcius, equivale a {res} Farenheit");
}
else {
Console.WriteLine("\nConvertir a Centigrados\n");
Console.WriteLine("Ingrese los grados en Farenheit: "); temp=float.Parse(Console.ReadLine());
res = ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
}
Console.WriteLine("\nGracias por utilizar este programa!!");
