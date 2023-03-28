//imprimir la tabla de mulIplicar que el usuario decida, hasta donde lo decida.

void tablamultiplicar(int tabla, int n) {
    Console.WriteLine($"\nTabla del {tabla}");
    for(int i=1; i <= n; i++)
        Console.WriteLine($"{tabla} x {i} = {tabla*i}");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Que tabla deseas: "); int tabla = int.Parse(Console.ReadLine());
Console.Write("Hasta donde: "); int n = int.Parse(Console.ReadLine());

tablamultiplicar(tabla, n);