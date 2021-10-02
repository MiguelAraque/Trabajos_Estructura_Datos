using System;

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] ProductSales = new int[4,5];

        }
        static void requestProductSales(int[,] ProductSales)
        {
            for(int y = 0; y < ProductSales.GetLength(1); y++)
            {
                for(int x = 0; y < ProductSales.GetLength(0); x++)
                {
                    try
                    {
                        Console.WriteLine("Escribe el precio del producto {0} en la sucursal {1}", (x++), (y++));
                        ProductSales[x,y] = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El valor ingresado debe ser un numero entero");
                        y--;
                    }
                }
            }
        }

        static void showResults(int[,] productSales)
        {
            Console.Write("\t Producto 1 \t Producto 2 \t Producto 3 \t Producto 4");
            Console.Write("");
        }
    }
}
