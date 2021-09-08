using System;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("escribe las expresiones que representen cada una de las siguientes afirmaciones");
            Console.WriteLine("");
            //1.
            Console.WriteLine("1) Las ventas del producto A son las más elevadas."); 
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            if(A < B && A < C)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
            //2.
            Console.WriteLine("2) Ningún producto tiene unas ventas inferiores a 200."); 
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            if(A < 200 || B < 200 || C < 200)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
            //3.
            Console.WriteLine("3) Algún producto tiene unas ventas superiores a 400."); 
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            if(A < 400 || B < 400 || C < 400)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
            //4.
            Console.WriteLine("4) La media de ventas es superior a 500."); 
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            int m = (A + B + C)/3;
            if(m < 500)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
            //5.
            Console.WriteLine("5) El producto B no es el más vendido.");
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            if(B > A && B > C)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
            //6.
            Console.WriteLine("6) El total de ventas esta entre 500 y 1000.");
            Console.WriteLine("Escribe las ventas del producto A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe las ventas del producto C");
            C = Convert.ToInt32(Console.ReadLine());
            int t = A + B + C;
            if(t < 500 || t > 1000)
            {
                Console.WriteLine("No se cumplen la afirmación propuesta");
            }
            else
            {
                Console.WriteLine("Los datos concuerdan con la afirmación");
            }
        }
    }
}
