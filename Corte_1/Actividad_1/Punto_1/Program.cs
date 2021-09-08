using System;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.Write("");
            Console.WriteLine("Halla el valor absoluto de un numero");
            Console.WriteLine("Escribe el numero");
            n = Convert.ToInt32(Console.ReadLine());
            if(n < 0)
            {
                n = n - (n + n);
                Console.WriteLine("El valor absoluto es {0}", n);
            }
            else
            {
                Console.WriteLine("El valor absoluto es {0}", n);
            }
        }
    }
}
