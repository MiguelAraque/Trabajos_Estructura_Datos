using System;
using System.Collections;

namespace Punto9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();   
            requestNumbers(Queue1, 3);
            CloneQueue(Queue1, Queue2);
            Console.WriteLine("Cola orginal");
            printQueueValues(Queue1);
            Console.WriteLine("Cola Clonada");
            printQueueValues(Queue2);
        }

        static void requestNumbers(Queue Numbers, int Total)
        {
            Random RNumber = new Random();
            for(int y = 0; y < Total; y++)
            {
                Numbers.Enqueue(RNumber.Next(1,10));
            }
        }

        static void CloneQueue(Queue originalQueue, Queue clonedQueue)
        {
            foreach (var item in originalQueue)
            {
                clonedQueue.Enqueue(item);
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
