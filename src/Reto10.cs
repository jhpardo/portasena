public class Reto10
{
   
    playToplay player = new playToplay(); 
    
    #nullable disable
    string posProd;
    bool isPlaying;
    double cambio;

    string[,] productos = new string[2,2];
    double[,] precios = new double[2,2];

    double[,] precio = new double[4,4]{{1700, 850, 1300, 900},
      {400, 900, 1250, 1100},
      {2200, 2400, 2200, 7700},
      {3100, 3250, 1850, 5500}};

    string[,] product = new string[4, 4]{{"Papas Super", "Galletas Super", "Chocorramo Org", "Pan de bimbo"},
      {"Chocolatina", "Oreo Paquete", "Taco Saltina", "Club Social"},
      {"Yogurt Alpina", "SpeedMax Litro", "Vive100 Litro", "RedBull Original"},
      {"Quesadillo Org", "Jamon Ahumado", "Bocadillo ", "Ensalada Atún"}};

    


    public void iniciar()  {

        Console.WriteLine("BIENVENIDOS: RETO 10");

        Console.WriteLine("\n¿Qué desea hacer? \n (1)Rellenar (2)Comprar");    
        int proc = Convert.ToInt32(Console.ReadLine());

         if (proc == 1)
        {
            rellenar();
            comprar(true);
        }else{
            comprar(false);
        }
    }

    void rellenar(){

        //Rellenando productos
        for (int i = 0; i < productos.GetLength(0); i++)
        {
            for (int j = 0; j < productos.GetLength(0); j++)
            {
                Console.Write($"Ingrese el producto de la posición {i}{j} \t");
                productos[i,j] = Console.ReadLine(); 
            }
        }

        //Rellenando precios
        for (int i = 0; i < precios.GetLength(0); i++)
        {
           for (int j = 0; j < precios.GetLength(1); j++)
            {
                Console.Write($"Ingrese el precio del producto {productos[i,j]}\t");
                precios[i,j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    void comprar(bool proceso){
        Console.WriteLine("INGRESA SU DINERO PARA COMPRAR");
        player.TotalDinero = Convert.ToDouble(Console.ReadLine());

        do
        {
            if (proceso)
            {
                maquina(productos, precios);     
            } else {
                maquina(product, precio);
            } 

            if (isPlaying){
                Console.WriteLine("\nMarque (X) para cancelar o marque una posición correcta...");
            }else{
                Console.WriteLine("\nIngrese la posición del producto");
            }

            posProd = Console.ReadLine();

            if (posProd.Equals("X") || posProd.Equals("x") ){
                isPlaying = false; 
            }else if (posProd.Length != 2){
                isPlaying = true;
            } else {
                isPlaying = false;
            }

        } while (isPlaying);
        calcPos(posProd, proceso);
    }
    
    void calcPos(string prod, bool proceso){

        string compra;
        double costoCompra;

        Console.WriteLine($"Tamaño 1: {productos.GetLength(0)} - 2: {productos.GetLength(0)}");

/*
        int[,] a = new int[17, 2];
            int i = a.Rank;
            for(int x = 0; x < i; x++)
            {
                Console.WriteLine(a.GetLength(x));
            }
*/

//Validar error si da una longitud de matrix equivocada con la 
//linea 104 donde se tiene que confirmar los 2 numeros que ingresan sean menores o iguales a cada uno del tamaño






        if (prod.Length == 2)
        {
            if (proceso == true){
                compra = productos[(int)Char.GetNumericValue(prod[0]),(int)Char.GetNumericValue(prod[1])];
                costoCompra = Convert.ToDouble(precios[(int)Char.GetNumericValue(prod[0]),(int)Char.GetNumericValue(prod[1])]);
            }else {
                compra = product[(int)Char.GetNumericValue(prod[0]),(int)Char.GetNumericValue(prod[1])];
                costoCompra = Convert.ToDouble(precio[(int)Char.GetNumericValue(prod[0]),(int)Char.GetNumericValue(prod[1])]);
            }

            if (player.TotalDinero > costoCompra)
            {
                cambio = player.TotalDinero - costoCompra;
                Console.WriteLine($"{compra} ¡ADQUIRIDO!");
                Console.WriteLine($"Su cambio es: {cambio}");
            } else{
                Console.WriteLine("Dinero insuficiente. **Vuelva a intentar");
            }
        } 
    }

    public void maquina(string[,] pro, double[,] cos)
    {
        for (int i = 0; i < pro.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < pro.GetLength(1); j++)
            {
                Console.Write($"Posición {i}{j} \t");
            }
            Console.WriteLine(" ");
            for (int j = 0; j < pro.GetLength(1); j++)
            {
                Console.Write($"{pro[i,j]} \t");
            }
            Console.WriteLine(" ");
            for (int j = 0; j < cos.GetLength(1); j++)
            {
                Console.Write($"Precio: {cos[i,j]} \t");
            }
            Console.WriteLine("");
        }
    }
}
