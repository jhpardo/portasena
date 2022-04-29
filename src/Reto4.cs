public class Reto4
{
    Boolean play = true;

    public void start()
    {
        int decision = 1;

        do
        {
            juegoPPT();
            Console.WriteLine("Volver a jugar: Si(1), No(2)");
            decision = Convert.ToInt32(Console.ReadLine());
            if (decision != 1)
            {
                play = false;
            }
        }
        while (play);
    }

    public void juegoPPT()
    {
        Console.WriteLine("BIENVENIDOS: RETO 4");
        Console.WriteLine("RECUERDE QUE DEBE ELEGIR EL NUMERO CORRESPONDIENTE");
        Console.WriteLine("PIEDRA(1) - PAPEL(2) - TIJERA(3)");

        int p1 = Convert.ToInt32(Console.ReadLine());

        Random r = new Random();
        int maq = r.Next(1, 4);

        Console.WriteLine($"P1: {val(p1)}");
        Console.WriteLine($"MAQ: {val(maq)}");

        Console.WriteLine($"{ganador(p1, maq)}");
    }

    string val(int a)
    {
        if (a == 1)
        {
            return ("PIEDRA");
        }
        else if (a == 2)
        {
            return ("PAPEL");
        }
        else if (a == 3)
        {
            return ("TIJERA");
        }
        else
        {
            return ("OPCION INCORRECTA");
        }
    }

    string ganador(int p1, int maq)
    {
        if (
            (p1 == 1 && maq == 3) ||
            (p1 == 2 && maq == 1) ||
            (p1 == 3 && maq == 2)
        )
        {
            return ("GANADOR P1");
        }
        else
        {
            return ("GANADOR Maquina");
        }
    }
}
