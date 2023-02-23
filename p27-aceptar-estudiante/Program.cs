// Acepta a un estudiante en base a su edad y sus calificaciones

Console.Clear();
Console.WriteLine("Acepta a un estudiante en base a su edad y sus calificaciones\n");

Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());

if( edad < 18 ) {
Console.WriteLine("\nNO ACEPTAMOS MAYORES DE EDAD");
}else 
    Console.WriteLine("Ingrese calificacion 1: "); float c1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese calificacion 2: "); float c2 = float.Parse(Console.ReadLine());
    if(c1<8 || c2<8)Console.WriteLine ("\nNO ACEPTAMOS CON CALIFICACIONES MENORES A 8");
    else{
        Console.WriteLine($"BIENVENIDO {nombre} tienes {edad} y calificaciones {c1} y {c2}");
    }
    Console.WriteLine("\nGRACIAS POR PARTICIPAR");




