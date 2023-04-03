// Imprime un cuadro de r x c del caracter especificado, usando una función
void cuadro(int r, int c, char car) {
    for(int i=1;i<=r;i++) {
        for(int j=1;j<=c;j++)
        Console.Write($"{car} ");
        Console.WriteLine("");
    }
}
int r,c;
char car;
Console.Clear();
Console.WriteLine("Ingresa el caracter que deseas imprimir:");
car = Console.ReadLine()[0];
Console.WriteLine("Ingresa el número de renglones:"); r = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el número de columnas:"); c = int.Parse(Console.ReadLine());

cuadro(r,c,car);