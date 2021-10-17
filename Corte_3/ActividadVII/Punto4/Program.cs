using System;
using System.Collections;
namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue NumberList1 = new Queue();
            Queue NumberList2 = new Queue();
            requestNumbers(NumberList1, 3);
            requestNumbers(NumberList2, 3);
            showNumbers(NumberList1, NumberList2);            
        }
        static void requestNumbers(Queue NumberList, int limit)
        {
            Random RANDOMNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Enqueue(RANDOMNUMBER.Next(1,9));
            }
        }
        static void showNumbers(Queue NumberList, Queue NumberList2)
        {
            Console.WriteLine(" ArrayList 1 \t ArrayList 2");
            for(int y = 0; y < NumberList.Count; y++)
            {
                Console.Write($"\t{NumberList.Peek()}\t\t{NumberList2.Peek()} \n");
            }
        }
    }
}
