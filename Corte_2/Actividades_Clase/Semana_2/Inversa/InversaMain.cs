using System;
using System.Collections;

namespace Inversa
{
    class InversaMain
    {
        static void Main(string[] args)
        {
            int x, y;
            do
            {
                Console.Write("Escribe la longitud de la matriz: ");
                x = int.Parse(System.Console.ReadLine());
                Console.Write("Escribe la altura de la matriz: ");
                y = int.Parse(System.Console.ReadLine());
                if(x != y)
                {
                    Console.WriteLine("La longitud y la altura deben ser iguales");
                }    
            }while (x != y);
            int[,] Matriz = new int[x,y];
            requestNumbers(Matriz);
            inversa(Matriz);
        }
        static void requestNumbers(int[,] Matriz)
        {
            try
            {
                for(int x = 0; x < Matriz.GetLength(0); x++)
                {
                    for(int y = 0; y < Matriz.GetLength(1); y++)
                    {
                        Console.Write("Escribe el numero de la posicion [{0} , {1}]: ", (x + 1), (y + 1));
                        Matriz[x,y] = int.Parse(System.Console.ReadLine());
                    }
                }     
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico");
            }
        }
        static void inversa(int[,] Matriz)
        {
            Console.WriteLine("Primera fila");
            for(int x = 0; x < Matriz.GetLength(0); x++)
            {
                Console.Write($" {Matriz[x,x]}");
            }
            Console.WriteLine("");
            Console.WriteLine("Ultima fila");
            for(int x = Matriz.GetLength(0) - 1; x >= 0; x--)
            {
                Console.Write($" {Matriz[x,x]}");
            }
        }
    }
}
