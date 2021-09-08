using System;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3, n4, av; 
            Console.WriteLine("Calculadora de notas");
            Console.WriteLine("");
            Console.WriteLine("Escribe tu primera nota");
            Console.Write("");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe tu segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe tu tercera nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe tu cuarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());
            av = n1 + n2 + n3 + n4;
            av = av / 4;
            //Max Score
            if(n1 > n2 && n1 > n3 && n1 > n4)
            {
               Console.WriteLine("Nota Max: {0} ", n1); 
            }
            if (n2 > n1 && n2 > n3 && n2 > n4)
            {
                Console.WriteLine("Nota Max: {0} ", n2);
            }
            if (n3 > n1 && n3 > n2 && n3 > n4)
            {
                Console.WriteLine("Nota Max: {0} ", n3);
            }
            if (n4 > n1 && n4 > n2 && n4 > n3)
            {
                Console.WriteLine("Nota Max: {0} ", n4);
            }
            //Min Score
            if(n1 < n2 && n1 < n3 && n1 < n4)
            {
               Console.WriteLine("Nota Min: {0} ", n1); 
            }
            if (n2 < n1 && n2 < n3 && n2 < n4)
            {
                Console.WriteLine("Nota Min: {0} ", n2);
            }
            if (n3 < n1 && n3 < n2 && n3 < n4)
            {
                Console.WriteLine("Nota Min: {0} ", n3);
            }
            if (n4 < n1 && n4 < n2 && n4 < n3)
            {
                Console.WriteLine("Nota Min: {0} ", n4);
            }
            Console.WriteLine("Promedio: {0}", av);

        }
    }
}
