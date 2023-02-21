// Calcular la paga extra de un trabajador, jornada de 40hrs

String nombre;
int horas, extra;
float paga, total;

Console.Clear();
Console.WriteLine("Calcular la paga extra de un trabajador, jornada de 40hrs \n");

Console.Write("Ingresa tu nombre: "); nombre = Console.ReadLine();
Console.Write("Ingresa las horas trabajadas: "); horas=int.Parse(Console.ReadLine());
Console.Write("Ingresa pago por hora: "); paga=float.Parse(Console.ReadLine());

if( horas > 40 ) {
extra = horas - 40;
total = (40*paga) + (extra * paga * 2);
Console.WriteLine($"\nHoras extra: {extra}");
}
else total = horas * paga;
Console.WriteLine($"\nPago total: {total:n2}");