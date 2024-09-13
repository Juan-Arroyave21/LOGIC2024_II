
/* 12.	Una frutería ofrece las manzanas con descuento según la siguiente tabla
 * Usted determina el precio del kilo de manzanas como desarrollador. Determinar y mostrar cuánto pagará una persona que compre manzanas es esa frutería y cuál descuento fue el que se le aplicó, si fue que se le aplicó alguno.*/
public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese cuantos kilos de manzanas desea comprar: ");
        decimal kilosManzanas = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();

        const decimal precioKiloManzanas = 5000;
        decimal descuento, precioBruto, precioNeto, precioDescuento;


        if (kilosManzanas >= 0 && kilosManzanas <= 2)
        {
            descuento = 0;
        }
        else if (kilosManzanas > 2 && kilosManzanas <= 5)
        {
            descuento = 10;
        }
        else if (kilosManzanas > 5 && kilosManzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        precioBruto = precioKiloManzanas * kilosManzanas;
        precioDescuento = precioBruto * (descuento / 100);
        precioNeto = precioBruto - precioDescuento;

        Console.WriteLine($"El total a pagar por {kilosManzanas} kilos es de :  {precioNeto:C0}");
        Console.WriteLine();
        Console.WriteLine($"Se aplico un descuento del {descuento}% equivalente a {precioDescuento:C0}");
        Console.WriteLine();
    }
}