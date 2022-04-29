public class Reto2
{
    double peso = 0;

    int meses = 0;

    int dosis = 0;

    public void calcDosis()
    {
        Console.WriteLine("Por favor inserte la edad del Bebé en meses");
        meses = Convert.ToInt32(Console.ReadLine());

        dosis = (int) Math.Round(((peso + 10) / meses * 10) * 8);
        Console.WriteLine($"La dosis que debe dar al Bebé es: {dosis}");
    }
}
