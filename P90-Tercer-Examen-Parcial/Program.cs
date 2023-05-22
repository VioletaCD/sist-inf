﻿using System.Text.Json;
Red red = null;
string archivo = "redes.json";
string jsonRedes = "";
int op;


void Inicializar() {
    Console.Clear();
    Console.WriteLine("#############Inicializando con datos de prueba #############");
    if(red is null) {
        red = new Red(empresa:"Red Patito, S.A. de C.V", propietario:"Mr Pato Macdonald", domicilio:"Av. Princeton 123, Orlando Florida");
        red.AgregarNodo(new Nodo(ip:"192.168.0.10", tipo:"servidor", puertos:5, saltos:10, so:"Linux"));
        red.AgregarNodo(new Nodo(ip:"192.168.0.12", tipo:"equipoactivo", puertos:2, saltos:12, so:"ios"));
        red.AgregarNodo(new Nodo(ip:"192.168.0.20", tipo:"computadora", puertos:8, saltos:5, so:"Windows"));
        red.AgregarNodo(new Nodo(ip:"192.168.0.15", tipo:"servidor", puertos:10, saltos:22, so:"Linux"));

        red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2015-1635", vendedor:"microsoft", 
        descripcion:"HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario", tipo:"remota", fecha:DateTime.Parse("14/04/2015")));
        red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2017-0004", vendedor:"microsoft", 
        descripcion:"El servicio LSASS permite causar una denegacion de servicio", tipo:"local", fecha:DateTime.Parse("10/01/2011")));
        red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2017-3847", vendedor:"cisco", 
        descripcion:"Cisco Firepower Management Center XSS", tipo:"remota", fecha:DateTime.Parse("21/02/2017")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2009-2504", vendedor:"microsoft", 
        descripcion:"Multiples desbordamientos de enteros en APIs Microsoft .NET 1.1", tipo:"local", fecha:DateTime.Parse("13/11/2009")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2016-7271", vendedor:"microsoft", 
        descripcion:"Elevacion de privilegios Kernel Segura en Windows 10 Gold", tipo:"local", fecha:DateTime.Parse("20/12/2016")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad(clave:"CVE-2017-2996", vendedor:"adobe", 
        descripcion:"Adobe Flash Player 24.0.0.194 corrupcion de memoria explotable", tipo:"remota", fecha:DateTime.Parse("15/02/2017")));

        Console.WriteLine("\n############# Datos de prueba han sido cargados #############");
    } else {Console.WriteLine("\n#############Ya existen datos cargados #############");}
}


void AgregarNodo() {
    Nodo nodo = new Nodo();
    if(red is not null) {
        Console.Clear();
        Console.WriteLine("############# Agregar nodo a la red #############");
        Console.WriteLine("\nIntroduce los datos:");
        Console.Write("IP: "); nodo.Ip = Console.ReadLine();
        Console.Write("Tipo: "); nodo.Tipo = Console.ReadLine();
        Console.Write("Puertos: "); nodo.Puertos = int.Parse(Console.ReadLine());
        Console.Write("Saltos: "); nodo.Saltos = int.Parse(Console.ReadLine());
        Console.Write("SO: "); nodo.So = Console.ReadLine();
        red.AgregarNodo(nodo);
        Console.WriteLine("\n############# Nodo agregado #############");
        red.Nodos.ForEach(p => Console.WriteLine(p.ToString()));
    } else {Console.WriteLine("\n############# No hay datos en memoria para AgregarNodo #############");}
}


void AgregarVulnerabilidad() {
    Vulnerabilidad vulnerabilidad = new Vulnerabilidad();
    int op;
    if(red is not null) {
        Console.Clear();
        Console.WriteLine("############# Agregar vulnerabilidad al nodo #############");
        if(red.Nodos.Count != 0) {
            for(int i = 0; i < red.Nodos.Count; i++)
                Console.WriteLine($"{i} - {red.Nodos[i].Ip}");
            Console.Write("\nElige el nodo: "); op = int.Parse(Console.ReadLine());
            Console.Write("Introduce los datos:\n");
            Console.WriteLine(red.Nodos[op].ToString());
            Console.Write("Clave: "); vulnerabilidad.Clave = Console.ReadLine();
            Console.Write("Vendedor: "); vulnerabilidad.Vendedor = Console.ReadLine();
            Console.Write("Descripcion: "); vulnerabilidad.Descripcion = Console.ReadLine();
            Console.Write("Tipo(local/remota): "); vulnerabilidad.Tipo = Console.ReadLine();
            Console.Write("Fecha: "); vulnerabilidad.Fecha = DateTime.Parse(Console.ReadLine());
            red.Nodos[op].AgregarVulnerabilidad(vulnerabilidad);
            Console.WriteLine("\n############# Vulnerabilidad agregada #############");
            red.Nodos[op].Vulnerabilidades.ForEach(p => Console.WriteLine(p.ToString()));
        } else {Console.WriteLine("\n############# No hay nodos para Agregar Vulnerabilidad #############");}
    } else {Console.WriteLine("\n ############# No hay datos en memoria para Agregar Vulnerabilidad #############");}
}


void CargarDatos() {
    Console.Clear();
    Console.WriteLine("############# Cargar los datos de un archivo #############");
    if(File.Exists(archivo)) {
        jsonRedes = File.ReadAllText("redes.json");
        Console.WriteLine(jsonRedes);
        red = new Red();
        red = JsonSerializer.Deserialize<Red>(jsonRedes);
        Console.WriteLine("\n############# Los datos han sido cargados #############" + archivo);
    } else {Console.WriteLine("\n ############# El archivo de datos no existe #############");}
}


void GuardarDatos() {
    Console.Clear();
    Console.WriteLine("############# Guardar los datos en un archivo #############");
    if(red is not null) {
        jsonRedes = JsonSerializer.Serialize(red);
        File.WriteAllText(archivo,jsonRedes);
        Console.WriteLine("\n############# Datos guardados #############" + archivo);
    } else {Console.WriteLine("\n############# No hay datos en memoria para guardar #############");}
}


// Imprimir Reporte...
void Reporte() {
    char op;
    Console.Clear();
    Console.WriteLine("############# Reporte de red #############");
    if(red is not null) {
        Console.WriteLine("############# Datos generales de la red #############");
        Console.WriteLine($"{red.ToString()}");
        Console.WriteLine($"{red.Resumen()}");

        Console.WriteLine("\n\n############# Datos generales de los nodos #############");
        red.Nodos.ForEach(p => Console.WriteLine(p.ToString()));
        Console.WriteLine(red.NumSaltos());

        Console.WriteLine("\n\n ############# Vulnerabilidades por nodo #############");
        foreach(Nodo p in red.Nodos) {
            Console.WriteLine($"\n> IP: {p.Ip}, Tipo: {p.Tipo}\n");
            Console.WriteLine("Vulnerabilidades:");
            if(p.Vulnerabilidades.Count != 0) {
                p.Vulnerabilidades.ForEach(a => Console.WriteLine(a.ToString()));
            } else Console.WriteLine("No tiene vulnerabilidades...");
        }
    } else {
        Console.WriteLine("\n ############# No hay datos en memoria para reportar #############");
        Console.Write("############# Deseas cargar los datos de prueba (S/N)? #############");
        op = (Console.ReadLine()).ToUpper()[0];
        if(op == 'S') Inicializar();
    }
}


// Menu...
int Menu() {
    int op;
    Console.Clear();
    Console.WriteLine("************************ MENU ************************");
    Console.WriteLine("Datos de la Red .............................. ( 1 )");
    Console.WriteLine("Agregar Nodo ................................. ( 2 )");
    Console.WriteLine("Agregar Vulnerabilidad a un Nodo ............. ( 3 )");
    Console.WriteLine("Cargar los Datos de un Archivo ............... ( 4 )");
    Console.WriteLine("Guardar los Datos en un Archivo .............. ( 5 )");
    Console.WriteLine("Salir ........................................ ( 6 )");
    Console.Write("Elige Una Opción: ");
    op = int.Parse(Console.ReadLine());
    return op;
}


// Programa Principal...
do {
    op = Menu();
    switch(op) {
        case 1 : Reporte(); break;
        case 2 : AgregarNodo(); break;
        case 3 : AgregarVulnerabilidad(); break;
        case 4 : CargarDatos(); break;
        case 5 : GuardarDatos(); break;
        case 6 : Console.WriteLine("\n############# Gracias por usar el sistema #############\n");break;
    }
    Console.WriteLine("\n############# Presiona cualquier tecla para continuar #############");
    Console.ReadLine();
} while( op!= 6);