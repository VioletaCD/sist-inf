//EXAMEN PARCIAL 2

        int opcion = 0;
        float[] calificaciones = null;
        int n = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Leer n calificaciones flotantes");
            Console.WriteLine("2. Mostrar calificaciones");
            Console.WriteLine("3. Calcular promedio y mostrar calificaciones mayores al promedio");
            Console.WriteLine("4. Mostrar el complemento a 100 del arreglo");
            Console.WriteLine("5. Contar calificación");
            Console.WriteLine("6. Salir");

            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la cantidad de calificaciones: ");
                    n = int.Parse(Console.ReadLine());
                    calificaciones = LeerCalificaciones(n);
                    break;
                case 2:
                    if (calificaciones == null)
                    {
                        Console.WriteLine("Primero debe ingresar las calificaciones.");
                    }
                    else
                    {
                        MostrarCalificaciones(calificaciones);
                    }
                    break;
                case 3:
                    if (calificaciones == null)
                    {
                        Console.WriteLine("Primero debe ingresar las calificaciones.");
                    }
                    else
                    {
                        float promedio = CalcularPromedio(calificaciones);
                        Console.WriteLine("El promedio es: " + promedio);
                        MostrarCalificacionesMayoresAlPromedio(calificaciones, promedio);
                    }
                    break;
                case 4:
                    if (calificaciones == null)
                    {
                        Console.WriteLine("Primero debe ingresar las calificaciones.");
                    }
                    else
                    {
                        float[] complementos = CalcularComplementos(calificaciones);
                        MostrarComplementos(complementos);
                    }
                    break;
                case 5:
                    if (calificaciones == null)
                    {
                        Console.WriteLine("Primero debe ingresar las calificaciones.");
                    }
                    else
                    {
                        Console.Write("Ingrese una calificación: ");
                        float calificacion = float.Parse(Console.ReadLine());
                        int contador = ContarCalificacion(calificaciones, calificacion);
                        Console.WriteLine("La calificación " + calificacion + " aparece " + contador + " veces.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }


            Console.WriteLine("\n Para continuar presione cualquier tecla...");
            Console.ReadLine();
        } while (opcion != 6);

    float[] LeerCalificaciones(int n)
    {
        float[] calificaciones = new float[n];

        for (int i = 0; i < n; i++)
        {
            float calificacion;

            do
            {
                Console.Write("Ingrese la calificación #" + (i + 1) + ": ");
                calificacion = float.Parse(Console.ReadLine());
            } while (calificacion < 10 || calificacion > 100);

            calificaciones[i] = calificacion;
        }

        return calificaciones;
    }

    void MostrarCalificaciones(float[] calificaciones)
    {
        Console.WriteLine("Calificaciones:");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"{calificaciones[i]} ");
        }
    }

    float CalcularPromedio(float[] calificaciones)

    {
        float suma = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            suma += calificaciones[i];
           }

    return suma / calificaciones.Length;
}

void MostrarCalificacionesMayoresAlPromedio(float[] calificaciones, float promedio)
{
    Console.Write("Calificaciones mayores al promedio:");

    for (int i = 0; i < calificaciones.Length; i++)
    {
        if (calificaciones[i] > promedio)
        {
            Console.Write($"{calificaciones[i]} ");
        }
    }
}

float[] CalcularComplementos(float[] calificaciones)
{
    float[] complementos = new float[calificaciones.Length];

    for (int i = 0; i < calificaciones.Length; i++)
    {
        complementos[i] = 100 - calificaciones[i];
    }

    return complementos;
}

void MostrarComplementos(float[] complementos)
{
    Console.Write("Complementos: ");

    for (int i = 0; i < complementos.Length; i++)
    {
        Console.Write($"{complementos[i]} ");
    }
}

int ContarCalificacion(float[] calificaciones, float calificacion)
{
    int contador = 0;

    for (int i = 0; i < calificaciones.Length; i++)
    {
        if (calificaciones[i] == calificacion)
        {
            contador++;
        }
    }

    return contador;
}

