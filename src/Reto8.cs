public class Reto8 {

    public void notas(){
        Console.WriteLine("BIENVENIDOS: RETO 8");
        Console.WriteLine("Por favor ingrese la cantidad de notas a evaluar");
        int cantN = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[cantN];
        double notaFinal = 0;

        for (int i = 0; i < cantN; i++)
        {
            do
            {
                Console.WriteLine($"Por favor ingrese la nota N° {i+1}");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            } while (notas[i] < 0 || notas[i] > 5);
        }

        for (int i = 0; i < notas.Length; i++)
        {
            notaFinal = notaFinal + notas[i];
        }
        
        notaFinal = notaFinal/notas.Length;

        if (notaFinal < 3)
        {
            Console.WriteLine($"Nota final {notaFinal} REPROBASTE");
        } else if(notaFinal >= 3 && notaFinal <= 4){
            Console.WriteLine($"Nota final {notaFinal} PASASTE RASPANDO");
        } else{
            Console.WriteLine($"Nota final {notaFinal} APROBASTE CON BUENOS RESULTADOS");
        }
    }
}