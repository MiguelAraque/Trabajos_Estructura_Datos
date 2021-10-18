using System;
using System.Collections;
namespace Punto10
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();
            floatNumbersToQueue(Queue1, 4);
            TransferInvertedQueue(Queue1, Queue2);
            printQueueValues(Queue1);
            printQueueValues(Queue2);
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
        static void TransferInvertedQueue(Queue originalQueue, Queue invertedQueue)
        {
            float[] TempOriginalQueue = new float[originalQueue.Count];
            originalQueue.CopyTo(TempOriginalQueue, 0);
            Array.Reverse(TempOriginalQueue);
            foreach (var item in TempOriginalQueue)
            {
                invertedQueue.Enqueue(item);
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
