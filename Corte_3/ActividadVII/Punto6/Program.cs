using System;
using System.Collections;

namespace Punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();
            requestNumbers(Queue1, 4);
            Console.WriteLine("Cola original");
            printQueueValues(Queue1);
            TransferInvertedQueueItems(Queue1, Queue2);
            Console.WriteLine("Cola Modificada");
            printQueueValues(Queue2);
            Console.Write($"Numero de elementos de: \n Pila 1: {Queue1.Count} \n Pila 2: {Queue2.Count}");
        }
        static void requestNumbers(Queue NumberList, int limit)
        {
            Random RANDOMNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Enqueue(RANDOMNUMBER.Next(1,9));
            }
        }
        static void TransferInvertedQueueItems(Queue oldQueue, Queue newQueue)
        {
            int[] TempOldQueue = new int[oldQueue.Count];
            oldQueue.CopyTo(TempOldQueue, 0);
            Array.Reverse(TempOldQueue);
            foreach(var value in TempOldQueue)
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
            Console.WriteLine("");
        }
    }
}
