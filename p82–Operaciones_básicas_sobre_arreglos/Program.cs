const int MAX=100;
int op,pos,n=0;
//double[] nums = {10.5,6.8,10.22,14.33,22.1};
double nb;
double[] nums=new double[MAX];
double suma=0, promedio=0;
do{
    op = menu();


    switch(op){
        case 1:
            Console.Write("Cuantos elementos deseas: ");
            n = int.Parse(Console.ReadLine());
            if(n>MAX){
                Console.WriteLine("TE PASAS");
            }else{
                for(int i=0; i<n; i++){
                    Console.Write($"Elemento[{i+1}]= ");
                    nums[i] = double.Parse(Console.ReadLine());
                }
            }
        break;
        case 2 : Mostrar(nums,n); break;
        case 3 :
            suma = Suma(nums,n);
            promedio = suma / nums.Length;
            Console.WriteLine($"\n La suma es: {suma}");
            Console.WriteLine($"\n El promedio es: {promedio:f2}");
        break;
        case 4:
            Console.WriteLine($"\n El mayor es: {Mayor(nums,n)}");
            Console.WriteLine($"\n El menor es: {Menor(nums,n)}");
        break;

        case 5:
            Console.Write($"\n Ingrese el elemento a buscar: ");
            nb = int.Parse(Console.ReadLine());
            pos = Buscar(nums, nb,n);
            if(pos == -1) Console.WriteLine("Elemento NO encontrado");
            else  Console.WriteLine($"Encontrado en la posicion {pos}");
        break;

    }
    Console.WriteLine("\n Presione cualquier tecla para continuar..");Console.ReadLine();
}while(op != 6);

    int menu(){
        Console.Clear();
        Console.WriteLine("Leer elemetos en el arreglo............. [ 1 ]");
        Console.WriteLine("Mostar los elementos del arreglo........ [ 2 ]");
        Console.WriteLine("Calcular y mostrar la suma y promedio... [ 3 ]");
        Console.WriteLine("Calcular y mostrar mayor y menor ....... [ 4 ]");
        Console.WriteLine("Buscar elemento en el arreglo .......... [ 5 ]");
        Console.WriteLine("Salir .................................. [ 6 ]");
        Console.Write("Elige una opcion: ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }

   void Mostrar(double[] a, int n){
        for(int i=0; i<n; i++)
            Console.Write($"{a[i]} ");
   }

   double Suma(double[] a, int n){
        double suma = 0;
        for(int i=0; i<n; i++)
            suma = suma + a[i];
        return suma;
   }

   double Mayor(double[] a, int n){
        double may = a[0];
        for(int i=0; i<n; i++)
            if(a[i]>may)
                may = a[i];
        return may;
   }
    double Menor(double[] a, int n){
        double men = a[0];
        for(int i=0; i<n; i++)
            if(a[i] < men)
                men = a[i];
        return men;
   }

    int Buscar(double[] a, double nb, int n){
        int pos = -1;
    
        for(int i=0; i<n; i++)
            if(a[i] ==nb)
                pos = i;
        return pos;
   }