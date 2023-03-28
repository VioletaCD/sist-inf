// suma de un rango de numeros
float SumaRango(float i, float f) {
float s=0;
for(float j=i; j <= f ;j++)
s += j;
return s;
}
float ini, fin, res;
Console.Clear();
do {
Console.Write("Inicio : "); ini = float.Parse(Console.ReadLine());
Console.Write("Fin : "); fin = float.Parse(Console.ReadLine());
} while( ini > fin);
res = SumaRango(ini, fin);
Console.WriteLine($"\nLa suma del rango es {res:n2}");