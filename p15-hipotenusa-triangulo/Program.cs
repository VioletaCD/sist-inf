// Calcula la hipotenusa de un triangulo

Console.Clear();
Console.WriteLine("Calcula la hipotenusa de un triangulo");

double hipotenusa, lad1,lad2;

hipotenusa=lad1=lad2=0;

Console.Write("Ingrese el lado 1: ");
lad1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el lado 2: ");
lad2 = double.Parse(Console.ReadLine());

hipotenusa= Math.Sqrt(lad1*lad1+lad2*lad2);

Console.WriteLine($"La hipotenusa es: {hipotenusa :f}");

