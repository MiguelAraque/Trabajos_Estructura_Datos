using System;
using System.Collections;
namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NumberList = new ArrayList();
            Console.Write("Escribe la cantidad de numeros asignada: ");
            int Total = int.Parse(System.Console.ReadLine());
            requestNumbers(NumberList, Total);
            CalculateSquareNumbers(NumberList);
        }
        static void requestNumbers(ArrayList NumberList, int TotalNumbers)
        {
            Random RNUMBER = new Random();
            for(int y = 0; y < TotalNumbers; y++)
            {
                NumberList.Add(RNUMBER.Next(1,10));
            }
        }
        static void CalculateSquareNumbers(ArrayList NumberList)
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
