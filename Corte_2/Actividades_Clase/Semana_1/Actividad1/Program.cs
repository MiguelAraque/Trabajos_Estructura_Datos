using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Weight, Height;
            Console.WriteLine("Escribe la longitud de la matriz");
            Weight = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Escribe la altura de la matriz");
            Height = double.Parse(System.Console.ReadLine());
            double[,] Numbers = new double[Weight,Height];     
            
            
        }
    }
}
