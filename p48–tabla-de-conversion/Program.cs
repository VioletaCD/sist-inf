// Imprime tabla de conversión de peso a dolar

float tc = 18.64f, te=19.95f;
float ini, fin, p;
char resp;

do{
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de peso a dolar\n");
do {
    Console.Write("Inicio: "); ini = int.Parse(Console.ReadLine());
    Console.Write("Fin: "); fin = int.Parse(Console.ReadLine());
} while(fin<ini);// se repite mientras el rango de valores no sea valido

p=ini;
Console.WriteLine(new string('-',40));
Console.WriteLine("Peso \t\t Dolar \t\t Euro");
Console.WriteLine(new string('-',40));
while(p <= fin){
Console.WriteLine($"{p:n2}\t\t{p/tc:f2}\t\t{p/te:f2}");
    p+=1;
}
Console.WriteLine(new string('-',40));

 Console.Write("\nDeseas continuar (S/N) ? "); resp = char.ToUpper( Console.ReadLine()[0] );
}while( resp!='N' );
    Console.WriteLine("\nGracias por utilizar este programa !");