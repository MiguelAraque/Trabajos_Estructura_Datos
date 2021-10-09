using System;
using System.Collections;

namespace Punto11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Numbers = new Stack();
            floatNumbersToStack(Numbers, 3);
            StackToQueue(Numbers);
            Console.WriteLine("Primero");
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Segundo");
            foreach (var item in StackToQueue(Numbers))
            {
                Console.WriteLine(item);
            }
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
        static Queue StackToQueue(Stack Numbers)
        {
            ArrayList TempStack = new ArrayList();
            Queue FinalQueue = new Queue();
            foreach (var item in Numbers)
            {
                TempStack.Add(item);
            }
            foreach (var item in TempStack)
            {
                FinalQueue.Enqueue(item);
            }
            return FinalQueue;
        }
    }
}