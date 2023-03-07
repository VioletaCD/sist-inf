// Comprar una pizza

Console.Clear();

Console.WriteLine("Programa que perimite armar el pedido de una pizza");

 double precioPizza = 0;
    double descuento = 0;
    Console.WriteLine("Tamaños de pizza:");
    Console.WriteLine("1. Chica - $5");
    Console.WriteLine("2. Mediana - $10");
    Console.WriteLine("3. Grande - $20");
    Console.Write("Seleccione un tamaño de pizza (1-3): ");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion) {
      case 1:
        precioPizza = 5;
        break;
      case 2:
        precioPizza = 10;
        break;
      case 3:
        precioPizza = 20;
        break;
      default:
        Console.WriteLine("Opción no válida.");
        break;
    }
    if (precioPizza != 0) {
      Console.Write("Ingrese la cantidad de pizzas que desea comprar: ");
      int cantidad = int.Parse(Console.ReadLine());
      double totalCompra = precioPizza * cantidad;
      Console.WriteLine("Tamaño de pizza: $" + precioPizza);
      Console.WriteLine("Cantidad comprada: " + cantidad);
      Console.WriteLine("Total compra: $" + totalCompra);
      if (totalCompra > 2000) {
        descuento = totalCompra * 0.15;
        Console.WriteLine("Descuento: $" + descuento);
        Console.WriteLine("Total de compra con descuento: $" + (totalCompra - descuento));
      } else {
        Console.WriteLine("Descuento: $0");
        Console.WriteLine("Total de compra con descuento: $" + totalCompra);
      }
    }
