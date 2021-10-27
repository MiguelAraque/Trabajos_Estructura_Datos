using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumberList = new int[4];
            loadNumbersToArray(NumberList);
            Console.WriteLine("Hello World!");
            
            ArrayTotal(NumberList);
        }
        static void ArrayTotal(int[] NumberArray)
        {
            int Total = 0;
            for (int i = 0; i < NumberArray.Length; i++)
            {
                Total+=NumberArray[i];
            }
            Console.Write(Total);
        }
        static void loadNumbersToArray(int[] NumberArray)
        {
            Random Rnumber = new Random();
            for (int i = 0; i < NumberArray.Length; i++)
            {
                NumberArray[i] = Rnumber.Next(1,10);
                Console.WriteLine(NumberArray[i]);
            }
        }
    }
}
