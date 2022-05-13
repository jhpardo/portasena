public class Reto9{

    int decision = 1;
    int cant = 0;

    #nullable disable
    string[] nombres = new string[0];

    public void competencia(){
        Console.WriteLine("BIENVENIDOS: RETO 9");
        
        cant = registro();

        do
        {
            Console.WriteLine("Marque (1) si acabó la carrera");
            decision = Convert.ToInt32(Console.ReadLine());
             
            if (decision != 1)
            {
                Thread.Sleep(3000); 
            }

        } while (decision != 1 );

        double[] cronoTiempos = new double[cant];

        tiempos(cronoTiempos);

    }

    int registro(){

        do
        {
            //Le aumento el tamaño a mi array para volverlo dinamico    
            Array.Resize(ref nombres, nombres.Length + 1);

            Console.WriteLine($"Ingrese el nombre del participante {cant + 1}");
            nombres[cant] = Console.ReadLine();
            cant++;
            Console.WriteLine("Marque (1) para registrar otro participante");
            decision = Convert.ToInt32(Console.ReadLine());
        } while (decision == 1);

        Console.WriteLine($"Total de participantes {nombres.Length}");


        return nombres.Length;
    }

    void tiempos(double[] tiempo){
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Ingrese el tiempo del participante {nombres[i]}");
            tiempo[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Participante: {nombres[i]} con un tiempo de: {tiempo[i]}");
            Console.WriteLine("- - - - - - - - - - - - - - -");
        }

        int indice = Array.IndexOf(tiempo, tiempo.Min());
        Console.WriteLine($"Ganador: {nombres[indice]} con un tiempo de {tiempo.Min()}");

    }

}