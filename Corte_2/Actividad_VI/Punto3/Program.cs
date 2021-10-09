using System;
using System.Collections;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NumberList = new ArrayList();
            Console.Write("Escribe la cantidad de numeros: ");
            int limit = int.Parse(System.Console.ReadLine());
            RequestNumbers(NumberList, limit);
            searchSpecificNumber(NumberList);
        }
        static void RequestNumbers(ArrayList NumberList, int limit)
        {
            Random RNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Add(RNUMBER.Next(1, 10));
                Console.Write("\n" + NumberList[y]);
            }
        }
        static void searchSpecificNumber(ArrayList NumberList)
        {
            ArrayList MatchList = new ArrayList();
            int MatchCounter = 0;
            int ListPosition = 0;
            Console.Write("\n Escribe el numero que quieres buscar: ");
            int valueSearch = int.Parse(System.Console.ReadLine());
            foreach(int value in NumberList)
            {
                if(value == valueSearch)
                {
                    MatchList.Add(ListPosition);
                    MatchCounter++;
                }
                ListPosition++;
            }
            if(MatchCounter == 0)
            {
                Console.WriteLine("null");
            }
            else
            {
                foreach(int value in MatchList)
                {
                   Console.Write($"\n El numero {valueSearch} se encuentra en la posición {value}");
                }
            }            
        }
    }
}
