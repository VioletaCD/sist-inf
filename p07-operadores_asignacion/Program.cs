﻿// Utiliza los operadores de asignacion para efectuar diversas operaciones
Console.Clear();
Console.WriteLine("Efectuando diversas operaciones usando los operadores de asignacion:\n");
Console.Write("agregue un numero: ");
float num=float.Parse(Console.ReadLine());
Console.WriteLine($"El numero original es: {num}");
Console.WriteLine($"Incremantar 1 : {++num}");
Console.WriteLine($"Sumar 50 : {num+=50}");
Console.WriteLine($"Restar 35 : {num-=35}");
Console.WriteLine($"Multiplicar por 15 : {num*=15}");
Console.WriteLine($"Dividir entre 4 : {num/=4}");
Console.WriteLine($"Decrementar 1 : {--num}"); 
