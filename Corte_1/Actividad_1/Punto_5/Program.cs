using System;

namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, r;
            Console.WriteLine("Calculadora de raiz cuadrada");
            Console.WriteLine("");
            Console.WriteLine("Escribe un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = Math.Sqrt(n);
            Console.WriteLine("La raiz cuadrada de {0} es {1}",n,r);

        }
    }
}
