using System;

namespace Matriz
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
            int[] Inicio = new int[x];
            int[] Fin = new int[x];
            requestWeight(Matriz, Inicio, 0);
            requestWeight(Matriz, Fin, (Matriz.GetLength(1) - 1));
            for(int i = 0; i < Inicio.Length; i++)
            {
                Console.Write("{0}, ", Inicio[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Fin.Length; i++)
            {
                Console.Write("{0}, ", Fin[i]);
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
        static void requestWeight(int[,] Matriz, int[] lista, int Posicion)
        {
            for(int x = 0; x < Matriz.GetLength(0); x++)
            {
                lista[x] = Matriz[x, Posicion];
            }
        }
    }
}
