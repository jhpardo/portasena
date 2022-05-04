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
            play = decision != 1 ? false : true;
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
        return (a == 1) ? "PIEDRA" : (a == 2) ? "PAPEL" : (a == 3) ? "TIJERA" : "OPCION INCORRECTA";
    }

    string ganador(int p1, int maq)
    {
        return ((p1 == 1 && maq == 3) || (p1 == 2 && maq == 1) || (p1 == 3 && maq == 2)) ? "GANADOR P1" : "GANADOR Maquina";
    }
}
