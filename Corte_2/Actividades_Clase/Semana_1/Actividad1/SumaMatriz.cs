using System;

namespace Actividad1
{
    class SumaMatriz
    {
        static void Main(string[] args)
        {
            int x,y;
            try
            {
                Console.WriteLine("Escribe la longitud de la matriz");
                x = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Escribe la altura de la matriz");
                y = int.Parse(System.Console.ReadLine());                 
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico"); 
            }    
            Console.WriteLine("Escribe la longitud de la matriz");
            x = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Escribe la altura de la matriz");
            y = int.Parse(System.Console.ReadLine());
            int[,] Numbers = new int[x,y];   
            requestNumbers(Numbers);
            showMatriz(Numbers);
            CalculateMiddleMatriz(Numbers);  
        }
        static void requestNumbers(int[,] Numbers)
        {
            for(int x = 0; x < Numbers.GetLength(0); x++)
            {
                for(int y = 0; y < Numbers.GetLength(1); y++)
                {
                    Console.WriteLine("Escribe el numero de la posición [{0},{1}]", (x + 1), (y + 1));
                    Numbers[x,y] = int.Parse(System.Console.ReadLine());
                }
            }
        }
        static void showMatriz(int[,] Matriz)
        {
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for(int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Console.Write("\t {0}", Matriz[x,y]);
                }
                Console.Write("\n");
            }
        }
        static void CalculateMiddleMatriz(int[,] Numbers)
        {
            int Middle = Numbers.GetLength(1) / 2;
            int Total = new int();
            for(int x = 0; x < Numbers.GetLength(0); x++)
            {
                Total += Numbers[x, Middle];
            }
            Console.WriteLine("La suma de la mitad es: ",Total);
        }
    }
}
