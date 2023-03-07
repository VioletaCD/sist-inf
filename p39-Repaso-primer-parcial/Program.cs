// Administrar la Venta de Pizzas

void Menu(){
Console.Clear();
Console.WriteLine("Arma aqui tu pedido: \n");
Console.WriteLine("Tamaño : [C]hica - $5 [M]ediana - $10 [G]rande - $15");
Console.WriteLine("Ingredientes: [E]xtra queso [C]hampiñoness [P]iña , unidos por un + - $5 por ingrediente");
Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
Console.WriteLine("Donde : [A]qui [L]levar");
}

char tam,cub,don;
string[] ings;

string Tamaño="", Ingredientes="",Cubierta="", donde="",cliente="";
float subtot=0, desc=0, total=0, cant=0;

if(args.Length<5){
    Menu();
    return 1;
}


//procesar ingredientes 
tam = char.Parse(args[0].ToUpper());
if(tam=='C'){ Tamaño = "Chica"; subtot+=5;}
else if (tam=='M'){ Tamaño = "Mediano"; subtot+=10;}
    else { Tamaño = "Grande"; subtot+=15;}

//procesar ingredientes
ings =args[1].Split("+");
foreach(string ing in ings){
    switch(char.Parse(ing.ToUpper() )){
        case 'E': Ingredientes+= "ExtraQueso "; break;
        case 'C': Ingredientes+= "Champiñones "; break;
        case 'P': Ingredientes+= "Piña "; break;
    }
    subtot +=5;
}

//procesar cubierta
cub = char.Parse(args[2].ToUpper());
Cubierta=(cub=='D' ? "Delgada" : "Gruesa");

//donde

don = char.Parse(args[3].ToUpper());
donde = (don =='A' ? "Aqui" : "Llevar");

//cantidad

cant = float.Parse(args[4]);
subtot = subtot*cant;

//procesar descuento
if(subtot < 1000){desc=0; cliente= "Platino ";}
    else if(subtot < 2000){desc=0.20f; cliente= "Plata ";}
        else{desc=0.20f; cliente= "Oro ";}
total = subtot - (subtot*desc);

Console.WriteLine($"Tamaño: {Tamaño}");
Console.WriteLine($"Ingredientes: {Ingredientes }");
Console.WriteLine($"Cubierta: {Cubierta}");
Console.WriteLine($"Donde: {donde}");
Console.WriteLine($"Cantidad: {cant}, Subtotal: {subtot:c}, eres Cliente: {cliente}, Descuento: {subtot*desc:c} ({desc:p2}), Total: {total:c}");

return 0;