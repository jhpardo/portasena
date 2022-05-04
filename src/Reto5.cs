public class Reto5
{
    double valor;
    

    public void startR5(){
        Console.WriteLine("Bienvenidos a Supermercados Noé");
        Console.WriteLine("Por favor ingrese el valor de la compra del cliente");
        valor = Convert.ToDouble(Console.ReadLine());
        valor = superNoe(valor);
    }


    public double superNoe(double compra)
    {

        double totalPagar = 0;

        string[] mensaje = new string[5];

        mensaje[0] = "FELICITACIONES! Has sacado la Bolita ROJA obtuviste un 10% de descuento. Debera pagar ";
        mensaje[1] = "FELICITACIONES! Has sacado la Bolita AZUL obtuviste un 30% de descuento. Debera pagar ";
        mensaje[2] = "FELICITACIONES! Has sacado la Bolita AMARILLA obtuviste un 50% de descuento. Debera pagar ";
        mensaje[3] = "FELICITACIONES! Has sacado la Bolita BLANCA tu compra es totalmente gratis. Debera pagar ";
        mensaje[4] = "Total a pagar ";

        if (compra > 50000)
        {
            Random r = new Random();
            int colorB = r.Next(1, 5);

            if (colorB == 1)
            {
                totalPagar = Calc(compra, 10);
                Console.WriteLine( mensaje[0] + totalPagar );
            }
            if (colorB == 2)
            {
                totalPagar = Calc(compra, 30);
                Console.WriteLine( mensaje[1] + totalPagar);
            }

            if (colorB == 3)
            {
                totalPagar = Calc(compra, 50);
                Console.WriteLine( mensaje[2] + totalPagar);
            }

            if (colorB == 4)
            {
                totalPagar = Calc(compra, 100);
                Console.WriteLine( mensaje[3] + totalPagar);
            }

            return totalPagar;

        } else {
            Console.WriteLine( mensaje[4] + compra);
            return compra;
        }
    }

    double Calc(double compra, int desc)
    {
        return compra - (compra * desc / 100);
    }
}
