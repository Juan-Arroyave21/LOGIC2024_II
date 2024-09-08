public class Program
{
    private static void Main(string[] args)
    {
        //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos. 

        //Datos de Entrada
        //Declarar las variables, en este caso son 4:
        double x1, x2, y1, y2, d;

        //Vamos a inicializar mis variables pidiendoles sus valores por pantalla:
        Console.Write("Por favor ingrese el valor de x1: "); //Esta es la forma de escribir en pantalla
        x1 = Convert.ToDouble(Console.ReadLine()); //Esta es la forma de leer en pantalla

        Console.Write("Por favor ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //Proceso - cálculo de la variable "d";
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        //La clase Math tiene muchos métodos, entre ellos el método Sqrt, este señor recibe un parámetro dentro de sus ( ), ese parámetro es el número que yo le mando al método para que me saque la Raíz Cuarada!
        d = Convert.ToDouble(Math.Sqrt(suma));

        //Forma de concatenar a través del símbolo "$" se llama Interpolación:
        Console.WriteLine("Concatenar con $");
        Console.Write($"La distancia entre los pares ordenados ({x1},{y1}) y ({x2},{y2}) es: {d}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}