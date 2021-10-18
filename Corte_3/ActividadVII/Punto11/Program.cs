using System;
using System.Collections;

namespace Punto11
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Stack Stack1 = new Stack();
            floatNumbersToStack(Stack1, 4);
            StackToQueue(Stack1, Queue1);
            Console.WriteLine("Pila");
            printStackValues(Stack1);
            Console.WriteLine("Cola");
            printQueueValues(Queue1);
            
        }
        static void floatNumbersToStack(Stack Numbers, int limit)
        {
            Random rand = new Random();
            for(int i = 0; i < limit; i++)
            {
                float randomFloat = (float)rand.NextDouble();
                Numbers.Push(randomFloat);
            }
        }
        static void StackToQueue(Stack Numbers, Queue FinalQueue)
        {
            foreach (var item in Numbers)
            {
                FinalQueue.Enqueue(item);
            }
        }
        static void printQueueValues(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
        static void printStackValues(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
