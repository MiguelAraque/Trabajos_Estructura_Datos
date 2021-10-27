using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void plusWithoutParameters()
        {
            int number1 = 5;
            int number2 = 3;
            int Result = number1 + number2;
            Console.Write(Result);

        }
        static void plusWithParemeters(int number1, int number2)
        {
            int Result = number1 + number2;
            Console.Write(Result);
        }
    }
}
