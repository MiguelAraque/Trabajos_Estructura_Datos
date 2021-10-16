using System;
using System.Collections;
namespace Punto1
{
    class Program
    {
        static void Main()
        {
            Queue Cola1 = new Queue();
            Queue Cola2 = new Queue();
            Queue ColaFinal = new Queue();
            requestNumbers(Cola1);
            requestNumbers(Cola2);
            calculateProduct(Cola1, Cola2, ColaFinal);
            showNumbers(Cola1, Cola2, ColaFinal);
        }
        static void requestNumbers(Queue Cola)
        {
            int i = 1;
            int value = 1;
            do
            {
                try
                {
                    Console.Write($"Escribe el numero {i}: ");
                    value = int.Parse(System.Console.ReadLine());
                    if(value != 0)
                    {
                        Cola.Enqueue(value);
                        i++;
                    }
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("El valor ingresado no es numerico, !intentalo de nuevo¡");
                    i--;
                }
            } while (value != 0);
        }
        static void calculateProduct(Queue Cola1, Queue Cola2, Queue ColaFinal)
        {
            try
            {
                int[] TempCola1 = new int[Cola1.Count];
                Cola1.CopyTo(TempCola1, 0);
                int[] TempCola2 = new int[Cola2.Count];
                Cola2.CopyTo(TempCola2, 0);
                for(int y = 0; y < TempCola1.Length; y++)
                {
                    ColaFinal.Enqueue(TempCola1[y] * TempCola2[y]);
                }
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("Las colas deben tener la misma cantidad de numeros, ¡Intentalo de nuevo!");
                Main();
            }
            
        }
        static void showNumbers(Queue Cola1, Queue Cola2 ,Queue ColaFinal)
        {
            int[] TempCola1 = new int[Cola1.Count];
            Cola1.CopyTo(TempCola1, 0);
            int[] TempCola2 = new int[Cola2.Count];
           Cola2.CopyTo(TempCola2, 0);
            int i = 0;
            foreach (var item in ColaFinal)
            {
                Console.WriteLine($"{i + 1}. {TempCola1[i]} * {TempCola2[i]} = {item}");
                i++;
            }
        }
    }
}