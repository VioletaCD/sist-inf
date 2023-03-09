// Procesa n calificaciones, calcula la suma y el promedio

int c,n;
float calif, suma, promedio;

calif=suma=promedio=0;

Console.Clear();
Console.WriteLine("Procesa n calificaciones, calcula la suma y el promedio");

Console.Write("Cuantas calicaciones vas a agregar: ");
n = int.Parse(Console.ReadLine());

c = 1;

while(c <= n){
   Console.Write($"Calificación: {c++}: ");
   calif = float.Parse(Console.ReadLine()); 
   suma += calif;
}
promedio = suma/n;

Console.WriteLine($"La suma es: {suma:f2} y el promedio es: {promedio:f2}");