public class Reto5
{
    double compra;

    public void superNoe()
    {
        Console.WriteLine("Bienvenidos a Supermercados Noé");
        Console
            .WriteLine("Por favor ingrese el valor de la compra del cliente");

        
        
        compra = Convert.ToDouble(Console.ReadLine());

        if (compra > 50000)
        {
            Random r = new Random();
            int colorB = r.Next(1, 5);
            Console.WriteLine (colorB);

            if (colorB == 1)
            {
                Console
                    .WriteLine("FELICITACIONES! Has sacado la Bolita ROJA obtuviste un 10% de descuento. Deberas pagar " +
                    Calc(compra, 10));
            }
            if (colorB == 2)
            {
                Console
                    .WriteLine("FELICITACIONES! Has sacado la Bolita AZUL obtuviste un 30% de descuento. Deberas pagar " +
                    Calc(compra, 30));
            }

            if (colorB == 3)
            {
                Console
                    .WriteLine("FELICITACIONES! Has sacado la Bolita AMARILLA obtuviste un 50% de descuento. Deberas pagar " +
                    Calc(compra, 50));
            }

            if (colorB == 4)
            {
                Console
                    .WriteLine("FELICITACIONES! Has sacado la Bolita BLANCA tu compra es totalmente gratis. Deberas pagar " +
                    Calc(compra, 100));
            }
        }
    }

    double Calc(double compra, int desc)
    {
        return compra - (compra * desc / 100);
    }
}
