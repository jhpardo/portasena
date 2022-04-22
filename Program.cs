using System;

                    namespace PORTASENA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            EJERCICIO 1

            Console.WriteLine("Hello World!");

            int num1, num2;
            int resultado = 0;

            Console.WriteLine("Digite el  primer numero ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el  segundo numero ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;

            Console.WriteLine($"SUMA: {num1} + {num2} = {resultado}" );
            
            */

            int costoPro = 10000;

            int cant , cambio, efectivo;

            Console.WriteLine("Bienvenidos...TODO a $10.000");
            Console.WriteLine("Cuantos productos son: ");
            cant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Con cuanto dinero pago el cliente ");
            efectivo = int.Parse(Console.ReadLine());

            cambio = efectivo - costoPro * cant;

            Console.WriteLine($"El total a pagar es {costoPro * cant} Devuelvale al usuario: { cambio }");
            //Console.WriteLine($"Devuelvale al usuario: { efectivo - costoPro * cant }");



            
        }
    }
}