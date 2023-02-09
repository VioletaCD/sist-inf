// Calcula el area de un triangulo
int ba, al;
float ar;
Console.WriteLine("Calcular el area de un triangulo:\n");
Console.Write("Dame la base : ");
ba = int.Parse(Console.ReadLine());
Console.Write("Dame la altura : ");
al = int.Parse(Console.ReadLine());
ar = ba * al / 2;
Console.WriteLine($"Un triangulo de base {ba} y {al} tiene un area de {ar}");