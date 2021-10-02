using System;
using System.Collections;

namespace ArrayListdatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();
            requestValues(List);
            showValues(List);
            showMiddleValue(List);
        }
        static void requestValues(ArrayList list)
        {
            Random RN = new Random();
            for(int y = 0; y < 10; y++)
            {
                list.Add(RN.Next(1,10));
            }
        }
        static void showValues(ArrayList list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item} \n");
            }
        }
        static void showMiddleValue(ArrayList list)
        {
            int middleValue = list.Count / 2;
            Console.WriteLine("{0} , {1}",list.Count,middleValue);
            Console.WriteLine($"El valor de la mitad es {list[middleValue]}");
        }
    }
}
