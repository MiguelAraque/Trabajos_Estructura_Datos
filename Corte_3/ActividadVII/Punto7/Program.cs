using System;
using System.Collections;

namespace Punto7
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();
            Queue FinalQueue = new Queue();
            floatNumbersToQueue(Queue1, 3);
            floatNumbersToQueue(Queue2, 3);
            Console.WriteLine("Cola 1");
            printQueueValues(Queue1);
            Console.WriteLine("Cola 2");
            printQueueValues(Queue2);
            TransferQueueItems(Queue1, Queue2, FinalQueue);
            Console.WriteLine("Cola final");
            printQueueValues(FinalQueue);
            Console.WriteLine($"Las pilas contienen: ");
            Console.WriteLine($"Pila 1: {Queue1.Count} \n Pila 2: {Queue2.Count} \n Pila 3: {FinalQueue.Count}");
        }
        static void floatNumbersToQueue(Queue NumberList, int limit)
        {
            Random rand = new Random();
            for(int i = 0; i < limit; i++)
            {
                float randomFloat = (float)rand.NextDouble();
                NumberList.Enqueue(randomFloat);
            }
        }
        static void TransferQueueItems(Queue queue1, Queue queue2, Queue newQueue)
        {
            foreach(var value in queue1)
            {
                newQueue.Enqueue(value);
            }
            foreach (var value in queue2)
            {
                newQueue.Enqueue(value);
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
    }
}
