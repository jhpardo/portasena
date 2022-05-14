public class Reto10
{
   
    playToplay player = new playToplay(); 
    
    #nullable disable
    string posProd;
    bool isPlaying;

    string[,] precio2 = new string[4,4];

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
        }else{
            comprar();
        }
    }

    void rellenar(){

        //Rellenando productos
        for (int i = 0; i < product.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < product.GetLength(0); j++)
            {
                Console.Write($"Ingrese el producto de la posición {i}{j} \t");
                precio2[i,j] = Console.ReadLine();
                
            }

            Console.WriteLine(" ");
           /* for (int j = 0; j < precio.GetLength(1); j++)
            {
                Console.Write($"Ingrese el precio del producto {precio2[i,j]}\t");
            }
            Console.WriteLine("");*/
        }

        
    }

    void comprar(){
        Console.WriteLine("INGRESA SU DINERO");
        player.TotalDinero = Convert.ToDouble(Console.ReadLine());

        do
        {
            maquina();

            if (isPlaying){
                Console.WriteLine("\nMarque (X) para cancelar o marque una posición correcta...");
            }else{
                Console.WriteLine("\nIngrese la posición del producto");
            }

            posProd = Console.ReadLine();

            if (posProd.Equals("X")){
                isPlaying = false; 
            }else if (posProd.Length != 2){
                isPlaying = true;
            } else {
                isPlaying = false;
            }

        } while (isPlaying);
        calcPos(posProd);
    }
    
    void calcPos(string prod){
        if (prod.Length == 2)
        {
            Console.WriteLine($"{prod[0]}  y {prod[1]}");

            //Pendiente calcular saldo con precio del producto
            Console.WriteLine("Posicion valida");
        }
    }

    public void maquina()
    {
        for (int i = 0; i < product.GetLength(0); i++)
        {

            Console.WriteLine(" ");
            for (int j = 0; j < product.GetLength(1); j++)
            {
                Console.Write($"{product[i,j]} \t");
            }

            Console.WriteLine(" ");
            for (int j = 0; j < precio.GetLength(1); j++)
            {
                Console.Write($"Precio: {precio[i,j]} \t");
            }

            Console.WriteLine("");
        }
    }
}
