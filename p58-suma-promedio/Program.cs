// Suma y promedio de n calificaciones
int n;
float num, s, p;
char resp;
do {
    Console.Clear();
    s=p=0;
    Console.Write("Cuantas números: "); n=int.Parse(Console.ReadLine());

    for(int i=1; i<=n; i++) {
        do{
        Console.Write($"Calificacion {i} : ");
        num=float.Parse(Console.ReadLine());
        }while(num<0 || num >10);
        s+=num;
        }
        Console.WriteLine($"\nLa suma es: {s}");
        p=s/n;
        Console.WriteLine($"El promedio es: {p}");

        Console.Write("\nDeseas continuar (S/N) ? ");
        resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado ...");
