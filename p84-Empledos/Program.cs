//Programa Principal

Console.Clear();
//Instanciar y reservar espacio en memoria
Empleado empleado01 = new Empleado();

//Instanciar, luego reservar espacio en memoria
Empleado empleado02;
empleado02 = new Empleado();
Empleado empleado03 = new Empleado("El Bob");
Empleado empleado04 = new Empleado("Patricio",30);

//Asignar valores a los datos a traves de las propiedades
empleado01.Nombre = "Juan";
empleado01.Edad = 22;
empleado02.Nombre = "Leonardo";
empleado02.Edad = 35;
//Invocar los metodos
empleado01.ImprimirDatos();
empleado02.ImprimirDatos();
empleado03.ImprimirDatos();
empleado04.ImprimirDatos();
