using System;

namespace Punto9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = new int[15,5];
            MakeSquare(square);
        }
        static void MakeSquare(int[,] square)
        {

            for(int y = 0 ; y < square.GetLength(1) ; y++)
            {
                if(y == 0 || y == 4)
                {
                    for(int x = 0 ; x < square.GetLength(0) ; x++)
                    {
                        Console.Write("1");
                    }
                }
                else
                {
                    for(int x = 0 ; x < square.GetLength(0) ; x++)
                    {
                        if(x == 0 || x == (square.GetLength(0) - 1))
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
