// cálcula del promedio de 5 calificaciones ingresadas por el usuario

Console.Clear();

Console.WriteLine("Programa que cálcula el promedio de 5 calificaciones ingresadas por el usuario");

 float suma = 0, promedio;
float cal1,cal2,cal3,cal4,cal5;

cal1=cal2=cal3=cal4=cal5=0;
        
        // Pedimos al usuario que ingrese las calificaciones
        Console.Write("Ingrese la calificacion 1: ");
        cal1 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese la calificacion 2: ");
        cal2 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese la calificacion 3: ");
        cal3 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese la calificacion 4: ");
        cal4 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese la calificacion 5: ");
        cal5 = float.Parse(Console.ReadLine());
        Console.WriteLine("\n");


        // Calculamos el promedio
        promedio = (cal1+cal2+cal3+cal4+cal5) / 5;
        
        //Console.WriteLine($"El promedio es: {promedio}");

        // condicionales

        if((promedio >0) && (promedio <= 6))
            Console.WriteLine($"Tu promedio es: {promedio}, REPROBADO");
            else if((promedio >6) && (promedio <= 7))
            Console.WriteLine($"Tu promedio es: {promedio}, PASAS DE PANSAZO");
            else if((promedio >7) && (promedio <= 8))
            Console.WriteLine($"Tu promedio es: {promedio}, BIEN, PUEDES MEJORAR");
            else if((promedio >8) && (promedio <= 9))
            Console.WriteLine($"Tu promedio es: {promedio}, MUY BIEN, SIGUE ASI");
            else if((promedio >9) && (promedio <= 10))
            Console.WriteLine($"Tu promedio es: {promedio:f}, EXCELENTE, TODO SACRIFICIO TIENE SU RECOMPENSA");

Console.WriteLine("\n ****FIN DEL PROCESO***");