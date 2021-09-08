using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Option;
            int [] vaccineCount = new int[3];
            int[] finalReport = new int [3];
            vaccineCount[0] = 1000;
            vaccineCount[1] = 1000;
            vaccineCount[2] = 1000;
            do
            { 
                Console.WriteLine("Escoge un punto de vacunacion");
                Console.WriteLine("1. Punto 1");
                Console.WriteLine("2. Punto 2");
                Console.WriteLine("3. Punto 3");
                Console.WriteLine("4. Salir");
                Console.Write("elige una opcion: ");
                Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        int count = 0;
                        Console.WriteLine("");
                        Console.Write("Cuantas dosis has usado: ");
                        count = Convert.ToInt32(Console.ReadLine());
                        vaccineCount[0] = vaccineCount[0] - count;
                        finalReport[0] = finalReport[0] + count;
                        if (vaccineCount[0] < 200)
                        {
                            Console.WriteLine("Has usado el 80% de las vacunas disponibles");
                        }
                        else if(vaccineCount[0] <= 0)
                        {
                            Console.WriteLine("Has usado el 100% de las vacunas");
                            vaccineCount[0] = 0;
                        }
                    break;
                    case 2:
                        count = 0;
                        Console.WriteLine("Cuantas dosis has usado");
                        count = Convert.ToInt32(Console.ReadLine());
                        vaccineCount[1] = vaccineCount[1] - count;
                        finalReport[1] = finalReport[1] + count;
                        if (vaccineCount[1] < 200)
                        {
                            Console.WriteLine("Has usado el 80% de las vacunas disponibles");
                        }
                        else if(vaccineCount[1] <= 0)
                        {
                            Console.WriteLine("Has usado el 100% de las vacunas");
                            vaccineCount[1] = 0;
                        }
                    break;
                    case 3:
                        count = 0;
                        Console.WriteLine("Cuantas dosis has usado");
                        count = Convert.ToInt32(Console.ReadLine());
                        vaccineCount[2] = vaccineCount[2] - count;
                        finalReport[2] = finalReport[2] + count;
                        if (vaccineCount[2] < 200)
                        {
                            Console.WriteLine("Has usado el 80% de las vacunas disponibles");
                        }
                        else if(vaccineCount[2] <= 0)
                        {
                            Console.WriteLine("Has usado el 100% de las vacunas");
                            vaccineCount[2] = 0;
                        }
                    break;
                    case 4:
                        Report(finalReport[0], finalReport[1], finalReport[2]);
                    break;
                    default:
                        Console.WriteLine("Escoge una opcion valida");
                    break;
                    
                }
            }while(Option != 4);
        }
        static void Report(int vaccineCount1 ,int vaccineCount2, int vaccineCount3)
        {
            Console.WriteLine("Reporte final");
            if(vaccineCount1 >= 1000)
            {
                Console.WriteLine("Has usado todas las vacunas disponibles");
            }
            else
            {
                Console.WriteLine("En el punto 1 se utilizaron {0} vacunas en el punto 1", vaccineCount1);
            }
            if(vaccineCount2 >= 1000)
            {
                Console.WriteLine("Has usado todas las vacunas disponibles");
            }
            else
            {
                Console.WriteLine("En el punto 2 se utilizaron {0} vacunas en el punto 2", vaccineCount2);
            }
            if(vaccineCount3 >= 1000)
            {
                Console.WriteLine("Has usado todas las vacunas disponibles");
            }
            else
            {
                Console.WriteLine("En el punto 3 se utilizaron {0} vacunas en el punto 3", vaccineCount3);
            }
        }
    }
}
