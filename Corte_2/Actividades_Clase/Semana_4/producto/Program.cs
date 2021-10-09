using System;
using System.Collections;

namespace producto
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Number1 = new ArrayList();
            ArrayList Number2 = new ArrayList();
            int limit = 5;
            loadArrayNumbers(Number1, Number2, limit);
            showNumbers(Number1, Number2); 

        }
        static void loadArrayNumbers(ArrayList Number1, ArrayList Number2, int limit)
        {
            Random RandomNumber = new Random();
            for(int y = 0; y < limit; y++)
            {
                Number1.Add(RandomNumber.Next(1,10));
                Number2.Add(RandomNumber.Next(1,10));
            }
        }
        static void showNumbers(ArrayList Number1, ArrayList Number2)
        {
            for(int y = 0; y < Number1.Count; y++)
            {
                Console.Write($"\n {Number1[y]} + {Number2[y]} = {(int) Number1[y] + (int)Number2[y]}");
            }
        }
    }
}
