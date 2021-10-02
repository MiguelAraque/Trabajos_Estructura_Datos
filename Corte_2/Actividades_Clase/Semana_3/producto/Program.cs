using System;
using System.Collections;

namespace producto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number1 = new int[8];
            ArrayList Number2 = new ArrayList();
            int limit = 5;
            loadArrayNumbers(Number1, Number2, limit);
            showNumbers(Number1, Number2); 

        }
        static void loadArrayNumbers(int[] Number1, ArrayList Number2, int limit)
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
            for(int x = 0; x < Number1.Count; x++)
            {
                
            }
        }
    }
}
