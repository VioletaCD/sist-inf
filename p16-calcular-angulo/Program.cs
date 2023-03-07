// Calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo

Console.Clear();
Console.WriteLine("Calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo");

int Angulo3, ang1,ang2;

Angulo3=ang1=ang2=0;

Console.Write("Ingrese el angulo 1: ");
ang1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el angulo 2: ");
ang2 = int.Parse(Console.ReadLine());

Angulo3= 180-(ang1 + ang2);

Console.WriteLine($"EL Angulo tres es igual a: {Angulo3} grados");

