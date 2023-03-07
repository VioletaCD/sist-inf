// Dados tres números enteros, verificar cual es el mayor.

Console.Clear();
Console.WriteLine("  Dados tres números enteros, verificar cual es el mayor.");

Console.WriteLine("Ingrese tres números enteros:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int mayor = num1;

        if (num2 > mayor) {
            mayor = num2;
        }

        if (num3 > mayor) {
            mayor = num3;
        }

        Console.WriteLine($"EL numero mayor es: {mayor}");
