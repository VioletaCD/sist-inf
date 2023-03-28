// Conversion de temperaturas usando funciones 
float farenheit(float t){
    return (t*9/5)+32;
}
float celcius(float t){
    return (t-32)*5/9;
}

//Programa principal
int op;
float temp, res;

Console.Clear();
Console.WriteLine("Conversion de temperatura usando funciones \n");
Console.WriteLine("[1] Farenheit \n[2]Centigrados");
Console.Write("Elige ? "); op = int.Parse(Console.ReadLine());

switch(op){
    case 1:
    Console.Write("Dame la temperatura en centigrados ? ");
    temp = float.Parse(Console.ReadLine());
    res = farenheit(temp);
    Console.WriteLine($"\n{temp} grados centigrados equivale a {res} grados farenheit");
    break;
    case 2:
    Console.Write("Dame la temperatura en Farenheit ?");
    temp = float.Parse(Console.ReadLine());
    res = celcius(temp);
    Console.WriteLine($"{temp} grados farenheit equivale a {res} grados celcius");
    break;
    default:
    Console.WriteLine("Opcion invalida");
    break;
}