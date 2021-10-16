using System;
using System.Collections;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue NumberList = new Queue();
            requestNumbers(NumberList, 3);
            CalculateSquareNumbers(NumberList);
        }
        static void requestNumbers(Queue NumberList, int TotalNumbers)
        {
            Random RNUMBER = new Random();
            for(int y = 0; y < TotalNumbers; y++)
            {
                NumberList.Enqueue(RNUMBER.Next(1,10));
            }
        }
        static void CalculateSquareNumbers(Queue NumberList)
        {
            int square;
            Console.WriteLine("Cuadrados de numeros enteros");
            foreach (var item in NumberList)
            {
                square = (int) item * (int) item;
                Console.Write($"\n {item}^2 = {square}");
            }
        }
    }
}
