// SDado un número entre 1 y 7 dame el dia de la semana
int dia;
Console.Clear();
Console.WriteLine("Dado un número entre 1 y 7 imprime el dia de la semana (1 Lunes) \n");
Console.Write("Dame el dia con número ?"); dia = int.Parse(Console.ReadLine());
switch(dia) {
    case 1 : Console.WriteLine("Lunes"); break;
    case 2 : Console.WriteLine("Martes"); break;
    case 3 : Console.WriteLine("Miercoles"); break;
    case 4 : Console.WriteLine("Jueves"); break;
    case 5 : Console.WriteLine("Viernes"); break;
    case 6 : Console.WriteLine("Sabado"); break;
    case 7 : Console.WriteLine("Domingo"); break;
    default : Console.WriteLine("En que dia vives !!!"); break;

}
Console.WriteLine(" \n Proceso terminbado...");
