  static int SumarDigitos(int num) {
    int sum = 0;

    while (num > 0) {
      sum += num % 10;
      num /= 10;
    }

    return sum;
  }

    Console.Clear();
   Console.WriteLine("Ingrese un numero entero: ");

    int num = int.Parse(Console.ReadLine());
    int sum = SumarDigitos(num);

    Console.WriteLine("La suma de los digitos del numero es: " + sum);