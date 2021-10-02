using System;

namespace Punto12
{
    class Program
    {
        static void Main()
        {
            int[,] Numbers = new int[12,12];
            int[,] InvertedNumbers = new int[12,12];
            requestNumbers(Numbers);
            CreateInvertedMatriz(Numbers, InvertedNumbers);
            showMatriz(Numbers, "Matriz Original");
            showMatriz(InvertedNumbers, "Matriz invertida");
            
        }
        static void requestNumbers(int[,] Numbers)
        {
            Random randomNumber = new Random();
            for(int y = 0; y < 12; y++)
            {
                for(int x = 0; x < 12; x++)
                {
                    Numbers[x,y] = randomNumber.Next(1,100);
                }
            }
        }
        static void CreateInvertedMatriz(int[,] Numbers, int[,] InvertedNumbers)
        { 
            int y_inverted = 11;
            for (int x = 0; x < 12; x++)
            {
                int x_inverted = 0;
                for(int y = 0; y < 12; y++)
                {
                    InvertedNumbers[x_inverted, y_inverted] = Numbers[x,y];
                    x_inverted++;
                }
                y_inverted--;
            }
        }
        static void showMatriz(int[,] Numbers, string matrizName)
        {
            Console.WriteLine(matrizName);
            for(int y = 0; y < 12; y++)
            {
                for(int x = 0; x < 12; x++)
                {
                    Console.Write("\t {0}", Numbers[x,y]);
                }
                Console.Write("\n");
            }
        }
    }
}
