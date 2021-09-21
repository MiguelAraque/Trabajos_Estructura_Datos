using System;

namespace Punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escribe el numero de alumnos a ingresar");
                int StudentLimit = int.Parse(System.Console.ReadLine());
                double[] StudentAverage = new double[StudentLimit];
                string[] StudentNames = new string[StudentLimit];
                double[,] Notes = new double[3, StudentLimit];
                requestStudentNotes(Notes,StudentLimit);
                StudentAV(Notes, StudentAverage, StudentLimit);
                showResults(StudentAverage,StudentLimit,Notes);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser un numero");
            }

        }
        static void requestStudentNotes(double[,] Notes, int StudentLimit)
        {
            for(int y = 0; y < StudentLimit; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    try
                    {
                        Console.Write("Escribe la nota {0} del estudiante {1}: ", (x + 1), (y + 1));
                        Notes[x,y] = int.Parse(System.Console.ReadLine());
                        Console.Write(" {0} \n", Notes[x,y]);                         
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El valor ingresado debe ser un numero");
                        y--;    
                    }
                }
            }
        }
        static void StudentAV(double[,] Notes, double[] studentAverage, int StudentLimit)
        {
            for(int y = 0; y < StudentLimit; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    studentAverage[y] += Notes[x,y];
                }
                studentAverage[y] /= StudentLimit;
            }
        }
        static double classAverage(double[,] Notes, int StudentLimit)
        {
            double ClassAV = 0; 
            for(int y = 0; y < StudentLimit; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    ClassAV += Notes[x,y];
                }
            }
            ClassAV /= Notes.Length;
            return ClassAV;
        }
        static double maxStudentAverage(double[] StudentAverage, int StudentLimit)
        {
            double maxAverage = 0;
            for(int y = 0; y < StudentLimit; y++)
            {
                if(StudentAverage[y] > maxAverage)
                {
                    maxAverage = StudentAverage[y];
                }
            }
            return maxAverage;
        }
        static void showResults(double[] StudentAverage, int StudentLimit, double[,] Notes)
        {
            for(int x = 0 ; x < StudentAverage.Length ; x++)
            {
                Console.Write("El promedio del estudiante {0} es: {1} \n", (x + 1), StudentAverage[x]);
            }
            Console.WriteLine("El estudiante con mayor promedio es: {0}",maxStudentAverage(StudentAverage, StudentLimit));
            Console.WriteLine("la clase tiene un promedio de: {0}",classAverage(Notes, StudentLimit));
        }
    }
}
