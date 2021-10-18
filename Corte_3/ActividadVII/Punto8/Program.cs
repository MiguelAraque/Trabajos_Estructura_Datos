using System;
using System.Collections;
namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Queue Queue2 = new Queue();
            requestNumbers(Queue1, 4);
            Console.WriteLine("Colas original \n Pila 1");
            printQueueValues(Queue1);
            requestNumbers(Queue2, 3);
            Console.WriteLine("Pila 2:");
            printQueueValues(Queue2);
            enchangeQueue(Queue1, Queue2);
            Console.WriteLine("Pila modificada \n Pila 1: ");
            printQueueValues(Queue1);
            Console.WriteLine("Pila 2: ");
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
        static void enchangeQueue(Queue Queue1, Queue Queue2)
        {
            int[] TempQueue1 = new int[Queue1.Count];
            int[] TempQueue2 = new int[Queue2.Count];
            Queue1.CopyTo(TempQueue1, 0);
            Queue1.Clear();
            Queue2.CopyTo(TempQueue2, 0);
            Queue2.Clear();
            foreach (var item in TempQueue2)
            {
                Queue1.Enqueue(item);
            }
            foreach (var item in TempQueue1)
            {
                Queue2.Enqueue(item);
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
