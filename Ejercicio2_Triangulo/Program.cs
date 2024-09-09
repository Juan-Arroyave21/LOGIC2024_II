// Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.
public class Program
{
    private static void Main(string[] args)
    {
        double seg1, seg2, seg3;
        bool isTriangle;

        Console.Write("Digite la longitud del segmento 1: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite la longitud del segmento 2: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite la longitud del segmento 3: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    isTriangle = true;
                }
                else
                {
                    isTriangle = false;
                }
            }
            else
            {
                isTriangle = false;
            }
        }
        else
        {
            isTriangle = false;
        }

        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3) > seg1))
        {
            isTriangle = true;
        }
        else
        {
            isTriangle = false;
        }
        if (isTriangle)
        {
            Console.Write("Se puede construir el triangulo");
        }
        else 
        {
            Console.Write("No se puede construir el triangulo");
        }
    }
}
