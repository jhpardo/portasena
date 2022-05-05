public class Reto1
{
    int tempF = 0;

    int tempC = 0;

    public void convTemp()
    {
        Console.WriteLine("BIENVENIDOS: RETO 1");
        Console.WriteLine("Por favor ingrese la temperatura deseada en °F");
        tempF = Convert.ToInt32(Console.ReadLine());

        tempC = (int) Math.Round((tempF - 32) / 1.8);
        Console
            .WriteLine($"ABUELITA, debes colocar el horno a {tempC} grados °C");
    }
}
