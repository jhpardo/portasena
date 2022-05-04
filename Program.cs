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

            Reto5 r5 = new Reto5();
            //r5.startR5();

            Reto6 r6 = new Reto6();
            //r6.registrar();

            Reto7 r7 = new Reto7();
           // r7.recargar();
        }
    }
}