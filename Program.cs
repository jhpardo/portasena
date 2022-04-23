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

            /* 
            
            EJERCICIO 2

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

            */

            /*

            EJERCICIO 3

            Console.WriteLine("Por favor digite el primer numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el segundo numero ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > 0)
            {
                Console.WriteLine($"El numero mayor es { num1 } y es un numero positivo");
            } else if ( num1 < num2){
                Console.WriteLine($"El numero mayor es { num2 }");
            } else {
                Console.WriteLine($"Los numeros son iguales");
            }*/

            /* 

            EJERCICIO 4

            Console.WriteLine("Por favor digite el primer numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el segundo numero ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El numero mayor es {num1} y {valNum(num1)}");

            }
            else
            {
                valNum(num2);
                Console.WriteLine($"El numero mayor es {num2} y {valNum(num2)}");
            }

            String valNum(int a)
            {
                if (a > 0)
                {
                    return "POSITIVO";
                }
                else if (a < 0)
                {
                    return "NEGATIVO";
                }
                else
                {
                    return "NEUTRO";
                }
            }
            */

            /* 

            EJERCICIO 5

            Console.WriteLine("Por favor digite el primer numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPERACION");
            String oper = Console.ReadLine();

            Console.WriteLine("Por favor digite el segundo numero ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Operaciones op = new Operaciones();

            switch (oper)
            {
                case "+":
                Console.WriteLine($"La suma da: { op.sumar(num1, num2) }");
                break;

                case "-":
                Console.WriteLine($"La resta da: { op.restar(num1, num2) }");
                break;

                case "*":
                Console.WriteLine($"La multiplicacion da: { op.multiplicar(num1, num2) }");
                break;

                case "/":
                Console.WriteLine($"La division da: { op.dividir(num1, num2) }");
                break;
                default:
                Console.WriteLine("No se reconocio la operacion");
                break;
            }

            */

            Console.WriteLine("BIENVENIDOS: RETO 4");
            Console.WriteLine("RECUERDE QUE DEBE ELEGIR EL NUMERO CORRESPONDIENTE");
            Console.WriteLine("PIEDRA(1) - PAPEL(2) - TIJERA(3)");

            Boolean play = true;

            int p1 = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int maq = r.Next(1, 4);

            Console.WriteLine($"P1: {val(p1)}");
            Console.WriteLine($"MAQ: {val(maq)}");

            switch ()
            {
                case :

                break;

                default:
                Console.WriteLine("Volver a jugar: Si(1), No(2)");
                int decision = Convert.ToInt32(Console.ReadLine());
                if ( decision != 1)
                {
                    play = false;
                } 
                break;
            }


            string val(int a)
            {
                if (a == 1)
                {
                    return ("PIEDRA");
                }
                else if (a == 2)
                {
                    return ("PAPEL");
                }
                else if (a == 3)
                {
                    return ("TIJERA");
                }
                else
                {
                    return ("OPCION INCORRECTA");
                }
            }




           

        }
    }
}