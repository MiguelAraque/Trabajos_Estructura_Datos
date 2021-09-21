using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[5,5];
            requestNumbers(Matriz);
            ShowNumbers(Matriz);
            
        }
        static void requestNumbers(int[,] Matriz)
        {
            for(int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write("Escribe un numero: ");
                    Matriz[x,y] = int.Parse(System.Console.ReadLine());
                    Console.Write("\n");
                }
            }
        }
        static void ShowNumbers(int[,] Matriz)
        {
            Console.WriteLine("\t\t\t Matriz");
            for(int x = 0; x < 5; x++)
            {
                for(int y = 0; y < 5; y++)
                {
                    Console.Write("\t {0} \t",Matriz[x,y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\t\t\t Matriz Compuesta");
            for(int y = 0; y < 5; y++)
            {
                for(int x = 0; x < 5; x++)
                {
                    Console.Write("\t {0} \t",Matriz[x,y]);
                }
                Console.Write("\n");
            }

        }
    }
}
