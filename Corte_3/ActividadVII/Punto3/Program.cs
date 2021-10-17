using System;
using System.Collections;
namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue NumberList = new Queue();
            RequestNumbers(NumberList, 4);
            searchSpecificNumber(NumberList);
        }
        static void RequestNumbers(Queue NumberList, int limit)
        {
            Random RNUMBER = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Enqueue(RNUMBER.Next(1, 10));
            }
            Console.WriteLine("Numeros en la cola");
            foreach(int value in NumberList)
            {
                Console.WriteLine(value);
            }
        }
        static void searchSpecificNumber(Queue NumberList)
        {
            Queue MatchList = new Queue();
            int MatchCounter = 0;
            int ListPosition = 1;
            Console.Write("\n Escribe el numero que quieres buscar: ");
            int valueSearch = int.Parse(System.Console.ReadLine());
            foreach(int value in NumberList)
            {
                if(value == valueSearch)
                {
                    MatchList.Enqueue(ListPosition);
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
