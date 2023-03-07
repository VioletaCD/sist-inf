// calcular el volumen de un cilindro dado su radio y altura

Console.Clear();
Console.WriteLine("Calcular el volumen de un cilindro dado su radio y altura");

double radio,altura,volumen;

volumen=radio=altura=0;

Console.Write("Ingrese el radio: ");
radio = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura: ");
altura = double.Parse(Console.ReadLine());

volumen = (Math.PI) * (radio * radio) * (altura);

Console.WriteLine($"EL volumen del cilindro es igual a: {volumen:f}");
