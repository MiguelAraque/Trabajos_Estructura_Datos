using System;

namespace Punto11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe el numero de conductores: ");
            int NumberofDrivers = int.Parse(System.Console.ReadLine());
            string[] DriverNames = new string[NumberofDrivers]; 
            double[,] DriverKMS = new double[7,NumberofDrivers];
            double[] TotalKMS = new double[NumberofDrivers];
            requestDriverNames(DriverNames); 
            requestKMS(DriverNames, DriverKMS);
            CalculateTotalKMS(DriverKMS,TotalKMS);
            showResults(DriverNames, DriverKMS, TotalKMS);
        }
        static void requestDriverNames(string[] DriverNames)
        {
            for(int y = 0; y < DriverNames.Length; y++)
            {
                Console.WriteLine("Escribe el nombre del empleado {0}", (y + 1));
                DriverNames[y] = Console.ReadLine();
            }
        }
        static void requestKMS(string[] DriverNames, double[,] DriverKMS)
        {
            for(int y = 0; y < DriverKMS.GetLength(1); y++)
            {
                for(int x = 0; x < DriverKMS.GetLength(0); x++)
                {
                    try
                    {
                        Console.Write("Escribe los kilometros recorridos del dia {0} del conductor {1}: ", (x + 1), DriverNames[y]);
                        DriverKMS[x,y] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El dato ingresado debe ser numerico");
                        x--;
                    }
                }
            }
        }
        static void CalculateTotalKMS(double[,] DriverKMS, double[] TotalKMS)
        {
            for(int y = 0; y < DriverKMS.GetLength(1); y++)
            {
                for(int x = 0; x < DriverKMS.GetLength(0); x++)
                {
                    TotalKMS[y] += DriverKMS[x,y];
                }
            }
        }
        static void showResults(string[] DriverNames, double[,] DriverKMS, double[] TotalKMS)
        {
            Console.Write("\t\t Lu \t Ma \t Mi \t Ju \t Vi \t Sá \t Do \t Total\n");
            for(int y = 0; y < DriverKMS.GetLength(1); y++)
            {
                Console.Write("\t {0}", DriverNames[y]);
                for(int x = 0; x < DriverKMS.GetLength(0); x++)
                {
                    Console.Write("\t {0}KM", DriverKMS[x,y]);
                }
                Console.Write("\t {0}KM \n", TotalKMS[y]);
            }
        }
    }
}
