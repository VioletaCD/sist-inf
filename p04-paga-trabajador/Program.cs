// Calcular la paga total de un trabajador
string nombre;
int horas;
float paga, pagabruta, paganeta, impuesto, tasa;
Console.WriteLine("Calculando la paga de un trabajador");
// Entrada
Console.Write("Nombre: ") ; nombre = Console.ReadLine();
Console.Write("Horas trabajadas: ") ; horas = int.Parse(Console.ReadLine());
Console.Write("Paga por hora: ") ; paga = float.Parse(Console.ReadLine());
tasa = 0.3f;
// Calculo
pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;
// Salida
Console.WriteLine("Resumen de pagos");
Console.WriteLine($"El trabajador {nombre}, trabajo {horas} horas, con una paga de {paga} pesos la hora, se asume una tasa de impuesto de {tasa}%");
Console.WriteLine($"Paga bruta: {pagabruta}");
Console.WriteLine($"Impuessto: {impuesto}");
Console.WriteLine($"Paga neta: {paganeta}"); 