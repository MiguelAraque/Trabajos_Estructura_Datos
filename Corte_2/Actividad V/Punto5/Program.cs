using System;

namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Escribe el ancho de la matriz(la matriz debe tener lados iguales): ");
            x = int.Parse(System.Console.ReadLine()); 
            int[,] Matriz1 = new int[x,x];
            int[,] Matriz2 = new int[x,x];
            int[,] Transpuesta = new int[x,x];
            int[,] MatrizSum = new int[x,x];
            requestMatrizNumbers(Matriz1, x);
            requestMatrizNumbers(Matriz2, x);
            createTranspuesta(Matriz2, Transpuesta, x);
            Console.WriteLine("Mtriz 1");
            showMatriz(Matriz1,x);
            Console.WriteLine("Mtriz 2");
            showMatriz(Matriz2, x);
            Console.WriteLine("Trans");
            showMatriz(Transpuesta, x);
            Console.WriteLine("La suma");
            matrizSum(Matriz1,Transpuesta, MatrizSum, x);
            showMatriz(MatrizSum,x); 
        }
        static void requestMatrizNumbers(int[,] Matriz, int largo)
        {
            for(int x = 0; x < largo; x++)
            {
                for(int y = 0; y < largo; y++)
                {
                    try
                    {
                        Console.WriteLine("Escribe un numero");
                        Matriz[x,y] = int.Parse(System.Console.ReadLine());    
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El dato ingresado debe ser numerico, intente de nuevo");
                        y--;
                    }
                    
                }
            }
        }
        static int[,] createTranspuesta(int[,] Matriz, int[,] Transpuesta, int limite)
        {
            for(int y = 0; y < limite; y++)
            {
                for(int x = 0; x < limite; x++)
                {
                    Transpuesta[x,y] = Matriz[y,x]; 
                }
            }
            return Transpuesta;
        }
        static void matrizSum(int[,] matriz1,int[,] matriz2, int[,] result, int limite)
        {           
            for(int y = 0; y < limite; y++)
            {
                for(int x = 0; x < limite; x++)
                {
                    result[x, y] = matriz1[x, y] + matriz2[x, y];
                }
            } 
        }
        static void showMatriz(int[,] Matriz, int limite)
        {
            for(int x = 0; x < limite; x++)
            {
                for(int y = 0; y < limite; y++)
                {
                    Console.Write("\t {0} \t", Matriz[x,y]);
                }
                Console.Write("\n");
            }                       
        }
    }
}
