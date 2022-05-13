using System;

namespace
PortaSena // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int next = 1;
            Console.WriteLine("Bienvenidos...");
            while (next == 1)
            {
                Console.WriteLine("¿Que reto desea ejecutar?");
                Console.WriteLine("Reto 1: Temperatura Abuelita");
                Console.WriteLine("Reto 2: Dosis Bebé");
                Console.WriteLine("Reto 3: Cara y Sello simple");
                Console.WriteLine("Reto 4: Piedra-Papel-Tijera");
                Console.WriteLine("Reto 5: Supermercado Noé Basico");
                Console.WriteLine("Reto 6: Supermercado Noé Completo");
                Console.WriteLine("Reto 7: Cara y Sello apuestas");
                Console.WriteLine("Reto 8: Notas materia C#");
                Console.WriteLine("Reto 9: Competencia de natación");
                int retos = Convert.ToInt32(Console.ReadLine());

                switch (retos)
                {
                    case 1:
                        Reto1 r1 = new Reto1();
                        r1.convTemp();
                        break;
                    case 2:
                        Reto2 r2 = new Reto2();
                        r2.calcDosis();
                        break;
                    case 3:
                        Reto3 r3 = new Reto3();
                        r3.start();
                        break;
                    case 4:
                        Reto4 r4 = new Reto4();
                        r4.start();
                        break;
                    case 5:
                         Reto5 r5 = new Reto5();
                        r5.startR5();
                        break;
                    case 6:
                        Reto6 r6 = new Reto6();
                        r6.registrar();
                        break;
                    case 7:
                        Reto7 r7 = new Reto7();
                        r7.recargar();
                        break; 
                    case 8:
                        Reto8 r8 = new Reto8();
                        r8.notas();
                        break;
                    case 9:
                        Reto9 r9 = new Reto9();
                        r9.competencia();
                        break;    
                    default:
                        Console.WriteLine("Reto no disponible o no existe...");
                        break;
                }
                Console.WriteLine("Marque (1) para ejecutar otro reto");
                next = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Hasta luego..."); 
        }
    }
}
