//convertir una temperatura de grados fahrenheit a grados celsius

Console.Clear();
Console.WriteLine("Convertir una temperatura de grados fahrenheit a grados celsius");

 double fahrenheit, celsius;

 Console.Write("Ingrese los grados Fahrenheit: ");
fahrenheit = Convert.ToDouble(Console.ReadLine());
 
 celsius = (fahrenheit - 32) * 5 / 9;
        
Console.WriteLine($"{fahrenheit} grados fahrenheit equivalen a: {celsius:f}°C");