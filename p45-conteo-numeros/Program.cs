// Cuenta numeros: positivos, negativos, ceros y calcula la suma

int n;
int c=0,s=0,cp=0,cn=0,cz=0;

Console.Clear();
Console.WriteLine("Cuenta números: postivos, negativos, ceros, y la suma\n");

do{
    Console.Write("Numero: "); n = int.Parse(Console.ReadLine());
    if(n != 999){
        c++;
        s += n;

        if(n > 0) cp++;
        else if(n < 0) c++;
            else cz++; 
    }

}while(n != 999);

Console.WriteLine("\n FIN DE CAPTURA...");
Console.WriteLine($"Numeros capturados {c} y su suma es {s}");
Console.WriteLine($"Positivos: {cp}, Negativos {cn}, Ceros: {cz}");