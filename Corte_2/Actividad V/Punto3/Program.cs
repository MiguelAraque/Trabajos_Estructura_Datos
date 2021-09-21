using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3,6];
            requestNumbers(num);
            showArrayNumbers(num);
        }
        static void requestNumbers(int[,] Num)
        {
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 6; y++)
                {
                    Console.Write("Escribe un numero: ");
                    Num[x,y] = int.Parse(System.Console.ReadLine());
                    Console.Write("\n");
                }
            }
        }
        static void showArrayNumbers(int[,] Num)
        {
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 6; y++)
                {
                    Console.Write("\t {0} \t", Num[x,y]);
                     
                }
                Console.Write("\n");
                
            }
        }
    }
}
