//Programa con una función que pida 4 números enteros y devuelva el menor de ellos.

        int num1, num2, num3, num4;

        Console.Clear();
        
        Console.WriteLine("Introduce el primer número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el tercer número:");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el cuarto número:");
        num4 = int.Parse(Console.ReadLine());

        int menor = EncontrarMenor(num1, num2, num3, num4);

        Console.WriteLine("El número menor es: " + menor);
    

    int EncontrarMenor(int a, int b, int c, int d) {
        int menor = a;

        if (b < menor) {
            menor = b;
        }
        if (c < menor) {
            menor = c;
        }
        if (d < menor) {
            menor = d;
        }

        return menor;
    }


