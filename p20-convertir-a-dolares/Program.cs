// Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares

Console.Clear();
Console.WriteLine("Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares");

double pesos, dolares;

pesos=0;
dolares= 0.056;


Console.Write("Ingrese la cantidad en pesos: ");
pesos = double.Parse(Console.ReadLine());

dolares = pesos * dolares;

Console.WriteLine($"{pesos:c} pesos equivalen a: {dolares:c} dolares");


