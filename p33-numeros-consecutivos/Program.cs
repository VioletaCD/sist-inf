// Dados tres números enteros, verificar si son consecutivos

Console.Clear();
Console.WriteLine(" Dados tres números enteros, verificar si son consecutivos");

    int num1,num2,num3;

    num1=num2=num3=0;

Console.WriteLine("Ingrese un numero entero:");
        num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo numero entero:");
        num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un tercer numero entero:");
        num3 = int.Parse(Console.ReadLine());

 if (num2 == num1 + 1 && num3 == num2 + 1) {
            Console.WriteLine("Los números son consecutivos");
        } else {
            Console.WriteLine("Los números no son consecutivos");
        }