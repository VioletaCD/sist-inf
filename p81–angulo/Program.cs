//programa con una función que reciba como parámetro un ángulo entre 0 y 360 grados, y regrese una palabra con el tipo de ángulo

char resp;
do {

    Console.Clear();

        Console.WriteLine("Introduce un ángulo en grados (entre 0 y 360):");
        double angulo = double.Parse(Console.ReadLine());

        string tipoAngulo = ObtenerTipoAngulo(angulo);

        Console.WriteLine("El ángulo " + angulo + " es " + tipoAngulo + ".");

    Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ...");


    string ObtenerTipoAngulo(double angulo) {
    
        if (angulo < 90) {
            return "agudo";
        } else if (angulo == 90) {
            return "recto";
        } else if (angulo > 90 && angulo < 180) {
            return "obtuso";
        } else if (angulo == 180) {
            return "llano";
        } else if (angulo > 180 && angulo < 360) {
            return "cóncavo";
        } else {
            return "inválido";
        }
    }

