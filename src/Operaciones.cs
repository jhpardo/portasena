public class Operaciones
{
    public int X
    {
        get;
    }
    public int Y 
    { 
        get; 
    }

    public double sumar(int a, int b){
        return a + b;
    }

    public double restar(int a, int b){
        return a - b;
    }

    public double dividir(int a, int b){
        double num1 = Convert.ToDouble(a);
        double num2 = Convert.ToDouble(b);
        return num1 / num2;
    }

    public double multiplicar(int a, int b){
        return a * b;
    }

}