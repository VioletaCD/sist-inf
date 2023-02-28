// efectua operaciones matematicas basicas con dos numeros

float n1, n2;
char op;

Console.Clear();
Console.WriteLine("Efectua operaciones matematicas basicas con dos numeros");
Console.Write("Ingrese un numero: "); n1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese otro numero: "); n2 = float.Parse(Console.ReadLine());
Console.Write("Operacion (+ - * /)");
op = Console.ReadLine()[0];

switch(op){
    case '+': Console.WriteLine($"n1 + n2 = {n1 + n2}"); break;
    case '-': Console.WriteLine($"n1 - n2 = {n1 - n2}"); break;
    case '*': Console.WriteLine($"n1 x n2 = {n1 * n2}"); break;
    case '/': Console.WriteLine($"n1 / n2 = {n1 / n2}"); break;
    default : Console.WriteLine("Operacion invalida"); break;
}

Console.WriteLine("PROCESO TERMINADO");


