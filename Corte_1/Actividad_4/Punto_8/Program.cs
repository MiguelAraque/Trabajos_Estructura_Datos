using System;

namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            do
            {
                Console.WriteLine("¿Cuantas personas vas a medir?");
                limit = Convert.ToInt32(Console.ReadLine());
                if(limit <= 0)
                {
                    Console.WriteLine("El numero de personas debe ser mayor a 1");
                }
            }while(limit <= 0);
            double[] Height = new double[limit];
            requestHeight(Height);
            CalculateAverage(Height);
            ShowResult(Height);
        }
        static void requestHeight(double[] Height)
        {
            for(int i = 0; i < Height.Length; i++)
            {
                Console.WriteLine("Escribe la altura de la persona {0}", (i + 1));
                Height[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        static double CalculateAverage(double[] Height)
        {
            double Average = 0;
            for(int i = 0; i < Height.Length; i++)
            {
                Average = Average + Height[i];
            }
            Average = Average / Height.Length;
            return Average;
        }
        static void ShowResult(double[] Height)
        {
            int HigherCounter = 0, LowerCounter = 0;
            for(int i = 0; i < Height.Length; i++)
            {
                if(Height[i] < CalculateAverage(Height))
                {
                    LowerCounter++;
                }
                else if(Height[i] > CalculateAverage(Height))
                {
                    HigherCounter++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Hay {0} personas menos altas que la media", LowerCounter);
            Console.WriteLine("Hay {0} personas mas altas que la media", HigherCounter);
        }
    }
}
