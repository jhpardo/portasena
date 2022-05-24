public class Reto11 {

    List<string> baul = new List<string>();
    bool addObject;

    public void inicio(){

        Console.WriteLine("Bienvenido al reto 11");

        adicionar();
        listar();
        borrar();
        listar();
        
    }

    void listar(){
        for(int i = 0; i < baul.Count(); i++) {
            Console.WriteLine($"OBJETO {i}: {baul[i]}");
        }
    }

    void borrar(){
        Console.WriteLine("Especifique el index del objeto que borrara");
        int res = Convert.ToInt32(Console.ReadLine());
        baul.RemoveAt(res);
    }

    void adicionar(){
        do
        {
            Console.WriteLine("Por favor ingresa un objeto");
            baul.Add(Console.ReadLine());

            Console.WriteLine("Presione (1) para añadir otro objeto");
            int res = Convert.ToInt32(Console.ReadLine());
            addObject = res == 1 ? true : false;
            baul.Sort();
        } while (addObject);
    }
}