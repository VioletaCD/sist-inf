// envia un saludo a la pantalla

string amigo="JUAN";
string hermano="Pablo";


Console.WriteLine(amigo);
amigo="MIGUEL";
Console.WriteLine(amigo);
Console.WriteLine($"HOLA {amigo} bienvenido a C#");
Console.WriteLine($"\n Mi amigo {amigo} mi hermano {hermano}\n");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");