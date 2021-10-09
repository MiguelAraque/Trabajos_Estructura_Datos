using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            Console.WriteLine("Escribe el tamaño del array");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int [] number = new int[limit];
            Random RNumber = new Random();
            Program.RandomNumber(number, RNumber);
            Program.showResults(number);
            Console.ReadKey();
        }
        private static void RandomNumber(int[] number,Random RandomNumber)
        {
            for(int i = 0; i < number.Length;i++)
            {
                number[i] = RandomNumber.Next(1, 9);
            }
        }
        static int ArraySum(int[] number)
        {
            int Total = 0;
            for(int i = 0; i < number.Length; i++)
            {
                Total = Total + number[i]; 
            }
            return Total;
        }
        static void showResults(int [] number)
        {
            for(int i = 0; i < number.Length;i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine("La suma de todos los numeros es {0}", Program.ArraySum(number));
        }
    }
}
