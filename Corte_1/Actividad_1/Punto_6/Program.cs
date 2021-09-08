using System;

namespace Punto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Seconds = 0, Minutes = 0, Hours = 0, Days = 0; 
            
            Console.WriteLine("Calculadora de tiempo");
            Console.WriteLine("");
            Console.WriteLine("Escoje una cantidad de tiempo(segundos)");
            Seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} segundos equivalen a", Seconds);
            Minutes = Seconds / 60;
            Hours = Seconds / 3600;
            Days = Seconds / 86400;
            Console.WriteLine("{0} segundos", Seconds);
            Console.WriteLine("{0} minutos", Minutes);
            Console.WriteLine("{0} dias", Days);
        }
    }
}
