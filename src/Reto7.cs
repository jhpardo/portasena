public class Reto7
{
    /* double totalDinero = 0;

    double valApostar = 0;

    int contPlays = 0;

    bool play = true;

    Reto3 r3 = new Reto3();

    public void recargar()
    {
        Console.WriteLine("INGRESA EL TOTAL DE DINERO PARA JUGAR");
        totalDinero = Convert.ToDouble(Console.ReadLine());

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
        Reto6 r6 = new Reto6();

        do
        {
            contPlays++;
            do
            {
                Console.WriteLine("Cuanto dinero quieres apostar ");
                valApostar = Convert.ToDouble(Console.ReadLine());
            }
            while ((r6.vericacion(totalDinero, valApostar)) == false);

            int decision = 1;
            r3.juegoLanzar(totalDinero, valApostar);
            contPlays++;
            Console.WriteLine("Volver a jugar: Si(1), No(2)");
            decision = Convert.ToInt32(Console.ReadLine());
            play = decision != 1 ? false : true;
        }
        while (play);
    }

    public void calcApuesta(string ganador, double tDinero, double tApostado)
    {
        Console.WriteLine("El ganador es borrar  " + ganador);
        if (ganador.Equals("GANADOR P1"))
        {
            tDinero += tApostado;
            r3.WinP1++;
        }
        else if (ganador.Equals("GANADOR Maquina"))
        {
            tDinero -= tApostado;
            r3.WinMaq++;
        }

        Console.WriteLine(tDinero);

    } */
}
