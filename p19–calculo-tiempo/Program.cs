// Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos

Console.Clear();
Console.WriteLine("Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos");

double horas, dias,minutos,segundos;

horas=dias=minutos=segundos=0;


Console.Write("Ingrese una cantidad de horas: ");
horas = double.Parse(Console.ReadLine());

dias = horas / 24;
minutos = horas * 60;
segundos = horas * 3600;

Console.WriteLine($"{horas} horas es igual a: {dias:f} dias");
Console.WriteLine($"{horas} horas es igual a: {minutos:f} minutos");
Console.WriteLine($"{horas} horas es igual a: {segundos:f} segundos");
