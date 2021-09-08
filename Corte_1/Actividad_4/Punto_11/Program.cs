using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_11
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Country = new String[4];
            String [,] City = new String[4,5];
            RequestCountry(Country);
            RequestCity(Country, City);
            ShowResults(Country, City);
        }
        static void RequestCountry(String[] Country)
        {
            for(int i = 0; i < Country.Length; i++)
            { 
                Console.WriteLine("Escribe el pais numero {0}", (i + 1));
                Country[i] = Convert.ToString(Console.ReadLine());
                   
            }
        }
        static void RequestCity(String[] Country, String[,] City)
        {
            int i = 0;

            for(int x = 0; x < 4; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    Console.WriteLine("Escribe una ciudad de {0}", Country[i]);
                    City[x,y] = Convert.ToString(Console.ReadLine());              
                }
                i++;
            }
        }
        static void ShowResults(String[] Country, String[,] City)
        {
            Console.WriteLine("");
            for(int x = 0; x < 4; x++)
            {
                Console.Write(" " + Country[x] + " ");
                Console.Write(" Ciudades: " );
                for(int y = 0; y < 4; y++)
                {
                    Console.Write(" "+City[x,y]+" ");           
                }
                Console.Write("\n");
            }
        }
    }
}
