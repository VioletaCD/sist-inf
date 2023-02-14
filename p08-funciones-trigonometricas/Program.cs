// Calcula funciones trigonometricas de un angulo en radianas
Console.Clear();
Console.WriteLine("Calculando las funciones trigonometricas de un angulo en radianes: \n");

Console.Write("Dame un angulo en Radianes: ");
double angulo = double.Parse(Console.ReadLine());


Console.WriteLine($"El angulo {angulo} tiene las siguientes funciones trigonometricas: \n");
Console.WriteLine("Seno: {0:f4}, Coseno: {1:f4}, tangente: {2:f4}",Math.Sin(angulo),Math.Cos(angulo),Math.Tan(angulo));

//double seno=Math.Sin(angulo);
//double coseno=Math.Cos(angulo);
//double tangente=Math.Tan(angulo);
//Console.WriteLine($"El Seno : {seno} ");
//Console.WriteLine($"El Coseno : {coseno} ");
//Console.WriteLine($"La Tangente : {tangente} ");