public class Reto7
{

    playToplay player = new playToplay(); 
    int contPlays,  winP1,  winMaq, emp;


    public void recargar()
    {
        Console.WriteLine("BIENVENIDOS: RETO 7");
        Console.WriteLine("INGRESA EL TOTAL DE DINERO PARA JUGAR");
        player.TotalDinero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Presione (1) para iniciar juego");
        int start = Convert.ToInt32(Console.ReadLine());

        if (start == 1)
        {
            apostar();
        }
        else
        {
            Console.WriteLine("Retira el dinero, hasta luego");
        }
    }

    void apostar()
    {
        do
        {
            bool play = true;
            contPlays++;
            do
            {
                double valApostadoLast = 0;
                Console.WriteLine("Cuanto dinero quieres apostar ");
                valApostadoLast = Convert.ToDouble(Console.ReadLine());

                if (player.Winner == true)
                {
                    if (valApostadoLast >= (player.ValApostar * 2))
                    {
                        player.ValApostar = valApostadoLast;
                    } else if (confirmar(player.TotalDinero, valApostadoLast).Conf == true)
                    {
                        player.ValApostar = valApostadoLast * 2;
                    }
                    
                } else
                {
                    player.ValApostar = valApostadoLast;
                    play = confirmar(player.TotalDinero, player.ValApostar).Conf;
                }
   
            }
            while (play == false);

        
            juegoLanzar();
            contPlays++;
            Console.WriteLine("Volver a jugar: Si(1), No(2)");
            int decision = Convert.ToInt32(Console.ReadLine());
            player.Conf = decision != 1 ? false : true;
        }
        while (player.Conf);
        Console.WriteLine($"Jugaste un total de {winP1 + winMaq + emp} Tu saldo total es {player.TotalDinero}");
    }

     playToplay confirmar(double totalDinero, double valApostar){

        playToplay ptp = new playToplay();

        ptp.ValApostar = valApostar;
        ptp.TotalDinero = totalDinero;

        if (totalDinero < valApostar){
            Console.WriteLine("Verifique");
            ptp.Conf = false;
        } else {
            Console.WriteLine("Calculando...");
            ptp.Conf = true;
        }
        return ptp;
    }

    void juegoLanzar(){
        
        Console.WriteLine("RECUERDE QUE DEBE ELEGIR EL NUMERO CORRESPONDIENTE");
        Console.WriteLine("CARA(1) SELLO(2)");

        int p1 = Convert.ToInt32(Console.ReadLine());

        Random r = new Random();
        int maq = r.Next(1, 3);

        int moneda = r.Next(1, 3);

        Console.WriteLine($"P1: {val(p1)}");
        Console.WriteLine($"MAQ: {val(maq)}");

        Console.WriteLine($"EL RESULTADO DE LA MONEDA FUE: {val(moneda)}");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine($"{ganador(p1, maq, moneda)}");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

        if (ganador(p1, maq, moneda).Equals("GANADOR P1"))
        {
            player.TotalDinero += player.ValApostar;
            player.Winner = true;
            winP1++; 
            Console.WriteLine($"Se han jugado {winP1 + winMaq + emp}" + $" el dinero total {player.TotalDinero}");
        }
        else if (ganador(p1, maq, moneda).Equals("GANADOR Maquina"))
        {
            player.TotalDinero -= player.ValApostar;
            player.Winner = false;
            winMaq++;
            Console.WriteLine($"Se han jugado {winP1 + winMaq + emp}" + $" el dinero total {player.TotalDinero}");
        } else {
            player.ValApostar = 0;
            emp++;
            Console.WriteLine($"Se han jugado {winP1 + winMaq + emp}" + $" el dinero total {player.TotalDinero}");
        }
    }

    string val(int a)
    {
       return a == 1 ? "CARA" : a == 2 ? "SELLO" : "OPCION INCORRECTA";
    }

    string ganador(int p1, int maq, int moneda)
    {       
        return ((p1 == moneda) && (maq != moneda)) ? "GANADOR P1" : ((maq == moneda) && (p1 != moneda)) ? "GANADOR Maquina" : "EMPATE";
    }

}
