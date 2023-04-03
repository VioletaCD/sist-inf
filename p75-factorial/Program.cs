int CalcularFactorial(int numero) {
        if (numero == 0) {
            return 1;
        }
        
        int factorial = 1;
        
        for (int i = 1; i <= numero; i++) {
            factorial *= i;
        }
        
        return factorial;
    }

int numero;
        Console.Clear();
        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());
        
        int factorial = CalcularFactorial(numero);
        
        Console.WriteLine("El factorial de {0} es {1}.", numero, factorial);
