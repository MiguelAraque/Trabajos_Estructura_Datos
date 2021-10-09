using System;
using System.Collections;
namespace Punto12
{
    class Program
    {
        static void Main(string[] args)
        {            
            Queue Numbers = new Queue();
            Stack Final = new Stack();
            requestStackValues(Numbers, 3);
            QueueToStack(Numbers, Final);
            Console.WriteLine($"Valores en la cola: {Numbers.Count}");
            Console.WriteLine($"Valores en la pila: {Final.Count}");
        }
        static void requestStackValues(Queue Numbers, int limit)
        {
            for(int y = 0; y < limit; y++)
            {
                try
                {
                    Console.Write($"Escribe el numero {(y + 1)}: ");
                    Numbers.Enqueue(int.Parse(System.Console.ReadLine()));
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("El resultado debe ser numerico");
                    y--;
                }
            }
        }
        static void QueueToStack(Queue Numbers, Stack FinalStack)
        {
            foreach (var item in Numbers)
            {
                FinalStack.Push(item);
            }
            Numbers.Clear();
        }
    }
}
