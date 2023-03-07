// PROGRAMA PARA ADMISION DE ESTUDIANTES

Console.Clear();
 Console.WriteLine("Bienvenido al sistema de admisiones de la Universidad Kitty Kat SA");
            Console.WriteLine("Por favor ingrese la información del estudiante:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Sexo (h/m): ");
            char sexo = char.ToLower(Console.ReadKey().KeyChar); // convertir a minúscula y leer un solo carácter
            Console.WriteLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Calificación 1: ");
            double calificacion1 = double.Parse(Console.ReadLine());
            Console.Write("Calificación 2: ");
            double calificacion2 = double.Parse(Console.ReadLine());
            Console.Write("Calificación 3: ");
            double calificacion3 = double.Parse(Console.ReadLine());

            // Verificar si el estudiante cumple con los requisitos
            if (sexo == 'h')
            {
                Console.WriteLine("\nLo siento, la Universidad Kitty Kat SA es solo para mujeres.\n");
            }
            else if (edad < 21)
            {
                Console.WriteLine("\nLo siento, la Universidad Kitty Kat SA es solo para mujeres mayores de 21 años.");
            }
            else if (calificacion1 < 8 || calificacion1 > 10 ||
                     calificacion2 < 8 || calificacion2 > 10 ||
                     calificacion3 < 8 || calificacion3 > 10)
            {
                Console.WriteLine("\nLo siento, las calificaciones deben estar entre 8 y 10.");
            }
            else
            {
                double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
                if (promedio >= 8 && promedio <= 9.5)
                {
                    Console.WriteLine("\n{0} ha sido aceptada en la Universidad Kitty Kat SA. ¡Felicidades!", nombre);
                }
                else
                {
                    Console.WriteLine("\nLo siento, el promedio de calificaciones debe estar entre 8 y 9.5 para ser aceptada.");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();