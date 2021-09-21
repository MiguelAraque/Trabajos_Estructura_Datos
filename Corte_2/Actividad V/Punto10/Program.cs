using System;

namespace Punto10
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxValue = null, minValue = null;
            int[,] Numbers = new int[6,10];
            requestMatrizNumbers(Numbers);
            showMatriz(Numbers);
            
            
            Console.WriteLine("\n {0} \n {1}",getMaxNumber(Numbers,maxValue), getMinNumber(Numbers,minValue));
            

        }
        static void requestMatrizNumbers(int[,] Numbers)
        {
            Random RandomNumber = new Random();
            for(int y = 0; y < Numbers.GetLength(1); y++)
            {
                for(int x = 0; x < Numbers.GetLength(0); x++)
                {
                    Numbers[x,y] = RandomNumber.Next(0,1000);
                }
            }
        }
        static string getMaxNumber(int[,] Numbers, string maxValue)
        {
            int MaxNumber = 0;
            for(int y = 0; y < Numbers.GetLength(1); y++)
            {
                for(int x = 0; x < Numbers.GetLength(0); x++)
                {
                    if(Numbers[x,y] > MaxNumber)
                    {
                        maxValue = "El numero maximo esta en la posicion " + (x + 1) +" , " + (y + 1);
                        MaxNumber = Numbers[x,y];
                    }
                }
            }
            return maxValue;
        }
        static string getMinNumber(int[,] Numbers, string minValue)
        {  
            int minNumber = 1001;
            for(int y = 0; y < Numbers.GetLength(1); y++)
            {
                for(int x = 0; x < Numbers.GetLength(0); x++)
                {
                    if(Numbers[x,y] < minNumber)
                    {
                        minValue = "El numero minimo esta en la posicion " + (x + 1) +" , " + (y + 1);
                        minNumber = Numbers[x,y];
                    }
                }
            }
            return minValue;
        }
        static void showMatriz(int[,] Numbers)
        {
            for(int y = 0; y < Numbers.GetLength(1); y++)
            {
                for(int x = 0; x < Numbers.GetLength(0); x++)
                {
                    Console.Write("\t {0}", Numbers[x,y]);
                }
                Console.Write("\n");
            }
        }
    }
}
