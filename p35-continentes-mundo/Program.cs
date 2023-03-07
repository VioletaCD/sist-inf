// Dado un número entero entre 1 y 6 que corresponde a un continente del mundo

int cont;

Console.Clear();

Console.WriteLine("Dado un número entero entre 1 y 6 imprime el nombre de un continente\n");
Console.Write("Ingrese un numero entero correspondiente a un contienente:"); cont = int.Parse(Console.ReadLine());

switch(cont) {
    case 1 : Console.WriteLine("Asia"); break;
    case 2 : Console.WriteLine("Africa"); break;
    case 3 : Console.WriteLine("América del Norte"); break;
    case 4 : Console.WriteLine(" América del Sur"); break;
    case 5 : Console.WriteLine("Antártida"); break;
    case 6 : Console.WriteLine("Europa"); break;
    default : Console.WriteLine("En que planeta vives !!!"); break;

}
Console.WriteLine(" \n Proceso terminbado...");