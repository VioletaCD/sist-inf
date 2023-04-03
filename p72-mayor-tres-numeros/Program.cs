int ObtenerMayor(int a, int b, int c) {
    int max = a;

    if (b > max) {
      max = b;
    }

    if (c > max) {
      max = c;
    }

    return max;
  }
    Console.Clear();
    Console.WriteLine("Ingrese tres numeros: ");

    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());

    int max = ObtenerMayor(num1, num2, num3);

    Console.WriteLine("El mayor de los tres numeros es: " + max);
