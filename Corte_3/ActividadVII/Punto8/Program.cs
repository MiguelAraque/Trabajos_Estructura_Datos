using System;

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worl!");
        }
        static void requestNumbers(Stack Numbers, int Total)
        {
            Random RNumber = new Random();
            for(int y = 0; y < Total; y++)
            {
                Console.Write($"\nEscribe el numero {y + 1}: ");
                int Value = int.Parse(System.Console.ReadLine());
                Numbers.Push(Value);
            }
        }
    }
}
