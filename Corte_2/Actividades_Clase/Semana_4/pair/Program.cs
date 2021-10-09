using System;
using System.Collections;
namespace pair
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NumberList = new ArrayList();
            Console.Write("Escribe el total de numeros a usar: ");
            int limit = int.Parse(System.Console.ReadLine());
            loadArrayListNumbers(NumberList, limit);
            evaluateNumbers(NumberList);
        }
        static void loadArrayListNumbers(ArrayList NumberList, int limit)
        {
            Random randomNumber = new Random();
            for(int y = 0; y < limit; y++)
            {
                NumberList.Add(randomNumber.Next(1,100));
            }
        }
        static void evaluateNumbers(ArrayList NumberList)
        {
            NumberList.Sort();
            foreach (int Number in NumberList)
            {
                if(Number % 2 == 0)
                {
                    Console.WriteLine($"{Number} = Par");
                }
                else
                {
                    Console.WriteLine($"{Number} = Impar");
                }
            }
            
        }
    }
}
