public   class Reto3 {


    Boolean play = true;

    public void start()
    {
        int decision = 1;

        do
        {
            juegoLanzar();
            Console.WriteLine("Volver a jugar: Si(1), No(2)");
            decision = Convert.ToInt32(Console.ReadLine());
            if (decision != 1)
            {
                play = false;
            }
        }
        while (play);
    }

    public void juegoLanzar(){
        
        Console.WriteLine("BIENVENIDOS: RETO 3");
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
    }

    string val(int a)
    {
        if (a == 1)
        {
            return ("CARA");
        }
        else if (a == 2)
        {
            return ("SELLO");
        }
        else
        {
            return ("OPCION INCORRECTA");
        }
    }

    string ganador(int p1, int maq, int moneda)
    {
        if ((p1 == moneda) && (maq != moneda))
        {
            return ("GANADOR P1");
        }
        
        if((maq == moneda) && (p1 != moneda))
        {
            return ("GANADOR Maquina");
        }

        return "EMPATE";
    }
   
}