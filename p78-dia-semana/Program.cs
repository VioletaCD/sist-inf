//Programa con una función que pida un número entero entre 1 y 7 y devuelva el día de la semana con letra.
        int dia;

        Console.Clear();
        Console.WriteLine("Introduce un número del 1 al 7:");
        dia = int.Parse(Console.ReadLine());

        // Llamamos a la función DiaSemana para obtener el nombre del día
        string diaSemana = DiaSemana(dia);

        Console.WriteLine("El día correspondiente es: " + diaSemana);
    
    string DiaSemana(int num) {
        
        string diaSemana = "";

        switch (num) {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }

        return diaSemana;
    }

