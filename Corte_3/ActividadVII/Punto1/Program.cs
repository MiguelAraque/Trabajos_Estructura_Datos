using System;
using System.Collections;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Numbers = new Queue();
            int counter = 1;
            requestNumbers(Numbers, counter);
        }
        static void requestNumbers(Queue Numbers, int counter)
        {
            int value = 1;
            try
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {counter}");
                    value = int.Parse(System.Console.ReadLine());
                    Numbers.Enqueue(value);
                    counter++;
                } while (value != 0);     
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico, intente de nuevo");
                counter--;
                requestNumbers(Numbers, counter);
            }
            
        }
    }
}