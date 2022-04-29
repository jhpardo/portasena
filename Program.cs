using System;

namespace PortaSena // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos");
            Reto1 r1 = new Reto1();
            //r1.convTemp();

            Reto2 r2 = new Reto2();
            //r2.calcDosis();

            Reto3 r3 = new Reto3();
            r3.start();

            Reto4 r4 = new Reto4();
            //r4.start();
        }
    }
}