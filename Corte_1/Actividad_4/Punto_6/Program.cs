using System;

namespace Punto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, lastNumber;
            Console.WriteLine("Escribe el limite de numeros");
            limit = Convert.ToInt32(Console.ReadLine());
            int[] numberList = new int[limit];
            Program.GenerateRandomNumber(numberList);
            do
            {
                Console.Write("Mostrar los numeros que acaben en: ");
                lastNumber = Convert.ToInt32(Console.ReadLine());
                if(lastNumber < 0 && lastNumber > 9)
                {
                    Console.WriteLine("numero no valido, intente de nuevo");
                }
            }while(lastNumber < 0 && lastNumber > 9);
            Program.lastDigitReader(numberList, lastNumber);
        }
        static void GenerateRandomNumber(int[] NumberList)
        {
            Random randomNumber = new Random();
            for(int i = 0; i < NumberList.Length; i++)
            {
                NumberList[i] = randomNumber.Next(1, 300);
                Console.WriteLine(NumberList[i]);
            }

        }
        static void lastDigitReader(int[] NumberList, int lastNumber)
        {
            int[] NumbersWithSameFinalDigit = new int[NumberList.Length];
            for(int i = 0; i < NumberList.Length; i++)
            {
                int lNumber = NumberList[i] % 10;
                
                if(lNumber == lastNumber)
                {
                    NumbersWithSameFinalDigit[i] = NumberList[i];
                    Console.WriteLine(NumberList[i]);
                }
            }
            
        }
    }
}
