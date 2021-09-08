using System;

namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Conjetura de Collatz");
            Console.WriteLine("");
            Console.WriteLine("Escribe un numero");
            n = Convert.ToInt32(Console.ReadLine());
            if(n %2 != 0)
            {
            n = n * 3 + 1;
            Console.WriteLine(n);
            }
            while(n %2 == 0 || n > 1)
            {
                n = n / 2;
                Console.WriteLine(n);
            }
            if(n %2 != 0 || n != 1)
            {
            n = n * 3 + 1;
            }

        }
    }
}
