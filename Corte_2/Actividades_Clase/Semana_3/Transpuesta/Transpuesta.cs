using System;

namespace Transpuesta
{
    class Transpuesta
    {
        static void Main(string[] args)
        {
            int x, y; 
            Console.WriteLine("Escribe el ancho de la matriz");
            x = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Escribe el largo de la matriz");
            y = int.Parse(System.Console.ReadLine());
            int[,] Matriz = new int[x,y];
            requestNumbers(Matriz);
            ShowNumbers(Matriz);
        }
        static void requestNumbers(int[,] Matriz)
        {
            Random RN = new Random();
            for(int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x,y] = RN.Next(1,10);
                }
            }
        }
        static void ShowNumbers(int[,] Matriz)
        {
            Console.WriteLine("Matriz");
            for(int y = 0; y < Matriz.GetLength(1); y++)
            {
                for(int x = 0; x < Matriz.GetLength(0); x++)
                {
                    Console.Write("\t {0} \t",Matriz[x,y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine(" Matriz Transpuesta");
            for(int x = 0; x < Matriz.GetLength(0); x++)
            {
                for(int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Console.Write("\t {0} \t",Matriz[x,y]);
                }
                Console.Write("\n");
            }
        }
    }
}

