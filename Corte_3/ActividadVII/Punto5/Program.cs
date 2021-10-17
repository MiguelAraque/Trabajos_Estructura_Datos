using System;
using System.Collections;

namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();
            requestNumbers(Queue1, 3);
            TransferQueueItems(Queue1, Queue2);
            Console.WriteLine($"La primera cola tiene {Queue1.Count} datos y la segunda tiene {Queue2.Count} datos");
        }
        static void requestNumbers(Queue NumberList, int limit)
        {
            Random RANDOMNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Enqueue(RANDOMNUMBER.Next(1,9));
            }
        }
        static void TransferQueueItems(Queue oldQueue, Queue newQueue)
        {
            foreach(var value in oldQueue)
            {
                newQueue.Enqueue(value);
            }
            oldQueue.Clear();
        }
        static void printQueueValues(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
