using System;

namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            
            Console.WriteLine("Escribe un numero");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("El suma de la secuencia da como resultado {0}", resolverSecuencia(N));
            
        }
        static double resolverSecuencia(int NumberofUser)
        {
            double Result = 0;
            for(int i = 1; i <= NumberofUser; i++)
            {
                Result = Result + (1.0/i);
            }
            return Result;
        }
    }
}
