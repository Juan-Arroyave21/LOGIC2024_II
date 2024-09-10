
// 10.	Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());


        double mayor, medio, menor;
        if (num1 >= num2 && num1 >= num3)
        {
            mayor = num1;
            if (num2 >= num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            mayor = num2;
            if (num1 >= num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if (num1 >= num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número del medio es: " + medio);
        Console.WriteLine("El número menor es: " + menor);
    }
}