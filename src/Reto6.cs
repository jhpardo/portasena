public class Reto6 {
    

    public void registrar(){

            bool regis = true;
            int products = 0;
            double totalPagar = 0;
            double valCli = 0;

            do
            {
                Console.WriteLine("Registrando...");
                products++;
                Console.WriteLine($"Ingrese precio del producto #{products}...");
                totalPagar = totalPagar + Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Continuar... Si(1) No(2)");
                int resp = Convert.ToInt32(Console.ReadLine());
                
                regis = resp != 1 ? false : true;

            } while (regis);

            Reto5 r5 = new Reto5();
            totalPagar = r5.superNoe(totalPagar);

            do
            {
                Console.WriteLine("El valor a pagar es: " + totalPagar);
                Console.WriteLine("Ingrese valor con el que el cliente paga");
                valCli = Convert.ToDouble(Console.ReadLine());
                
            } while ((vericacion(valCli, totalPagar)) == false);

            Console.WriteLine("Total productos comprados " + products);
            Console.WriteLine("Tu cambio " + (valCli - totalPagar));
    }

    public bool vericacion(double valCli, double totalPagar){

        if (valCli < totalPagar){
            Console.WriteLine("Verifique");
            return false;
        } else {
            Console.WriteLine("Calculando...");
            return true;
        }

    }

}