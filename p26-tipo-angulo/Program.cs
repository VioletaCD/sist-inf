// Muestra el tipo de angulo según los grados

Console.Clear();
Console.WriteLine("Muestra el tipo de angulo según los grados\n");

Console.Write("Ingrese un angulo entre 0 y 360°: ");
int angulo = int.Parse(Console.ReadLine());

if(angulo < 0 || angulo > 360){
    Console.WriteLine("ANGULO INVALIDO!!!");
}else{
if(angulo==0) Console.WriteLine("\nEl angulo es NULO");
if(angulo>0 && angulo<90) Console.WriteLine("\nEl angulo es AGUDO");
if(angulo==90) Console.WriteLine("\nEl angulo es RECTO");
if(angulo>90 && angulo<180) Console.WriteLine("\nEl angulo es OBTUSO");
if(angulo==180) Console.WriteLine("\nEl angulo es LLANO");
if(angulo>180 && angulo<360) Console.WriteLine("\nEl angulo es CONCAVO");
if(angulo==360) Console.WriteLine("\n 360° ES IGUAL A UNA CIRCUNFERENCIA");
}

Console.WriteLine("\n Proceso Terminado...");
