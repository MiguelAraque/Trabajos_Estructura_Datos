using System;
using System.Collections;
namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NumberList = new ArrayList();
            ArrayList NumberList2 = new ArrayList();
            int limit = 5;
            requestNumbers(NumberList, limit);
            requestNumbers(NumberList2, limit);
            showNumbers(NumberList, NumberList2);
        }
        static void requestNumbers(ArrayList NumberList, int limit)
        {
            Random RANDOMNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Add(RANDOMNUMBER.Next(1,9));
            }
        }
        static void showNumbers(ArrayList NumberList, ArrayList NumberList2)
        {
            Console.WriteLine(" ArrayList 1 \t ArrayList 2");
            for(int y = 0; y < NumberList.Count; y++)
            {
                Console.Write($"\t{NumberList[y]}\t\t{NumberList2[y]} \n");
            }
        }
    }
}
