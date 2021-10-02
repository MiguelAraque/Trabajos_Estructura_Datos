using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Numbers = new int[5,4];
            requestNumbers(Numbers);
            showNumbers(Numbers);
            Console.Write("\t\t" + ArrayTotal(Numbers));

        }
        static void requestNumbers(int[,] Numbers)
        {
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 5; x++)
                {
                    Console.Write("Escribe un numero: ");
                    Numbers[x, y] = Convert.ToInt32(System.Console.ReadLine());
                }
            }
        }
        static void showNumbers(int[,] Numbers)
        {
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 5; x++)
                {
                    Console.Write(" " + Numbers[x, y]);
                }
                Console.Write("\n");
            }
        }
        static int ArrayTotal(int[,] Numbers)
        {
            int total = 0;
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 5; x++)
                {
                    total = total + Numbers[x,y];
                }
            }
            return total;
        }
        static void requestNumbersTest(int[,] Numbers)
        {
            Random NRandom = new Random();
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 5; x++)
                {
    
                    Numbers[x, y] = NRandom.Next(100);
                }
            }
        }
    }
}
