using System;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            do
            {
                try
                {
                    Console.WriteLine("Escribe la longitud de la matriz");
                    x = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Escribe la altura de la matriz");
                    y = int.Parse(System.Console.ReadLine());
                    if(x != y)
                    {
                        Console.WriteLine("La longitud y altura deben ser iguales");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("El dato ingresado debe ser un numero entero");
                    
                }
                
            }while(x != y || y != x);
            int[,] Matriz = new int[x,y];
            loadMatrizNumbers(Matriz);
            CalculateDiagonal(Matriz);
        }
        static void CalculateDiagonal(int[,] Matriz)
        {
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                Matriz[i, (Matriz.GetLength(0) - 1) - i] = 1;

            }
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                for(int j = 0 ; j < Matriz.GetLength(0); j++)
                {
                    Console.Write(Matriz[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }
        static void loadMatrizNumbers(int[,] Matriz)
        {
            Random randomNumber = new Random();
            for(int y = 0; y < Matriz.GetLength(1); y++)
            {
                for (int x = 0; x < Matriz.GetLength(0); x++)
                {
                    Matriz[x,y] = randomNumber.Next(1,100);
                }
            }
        }
    }
}
