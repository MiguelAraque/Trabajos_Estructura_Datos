using System;
using System.Collections;

namespace Punto12
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Queue1 = new Queue();
            Stack Stack1 = new Stack();
            requestOption(Queue1);
            printQueueValues(Queue1);
            QueueToStack(Queue1, Stack1);
            printStackValues(Stack1);
            Console.WriteLine($"Queue: {Queue1.Count} \n Stack: {Stack1.Count}");
            
        }
        static void requestOption(Queue Queue1)
        {
            try
            {
                Console.WriteLine("¿Que quieres Hacer?");
                Console.WriteLine("1. Digitar los numeros");
                Console.WriteLine("2. Generar numeros aleatorios");
                Console.Write("Elige una opción: ");
                int option = int.Parse(System.Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.Write("Cuantos numeros desea agregar: ");
                        requestStackValues(Queue1, int.Parse(System.Console.ReadLine()));
                    break;
                    case 2:
                        Console.Write("Cuantos numeros desea agregar: ");
                        generateStackValues(Queue1, int.Parse(System.Console.ReadLine()));
                    break;
                    default:
                        Console.WriteLine("Elige una opción valida");
                        requestOption(Queue1);
                    break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico, vuelve a intentarlo");
                requestOption(Queue1);
            }
        }
        static void requestStackValues(Queue Numbers, int limit)
                {
                    for(int y = 0; y < limit; y++)
                    {
                        try
                        {
                            Console.Write($"Escribe el numero {(y + 1)}: ");
                            Numbers.Enqueue(int.Parse(System.Console.ReadLine()));
                        }
                        catch (System.FormatException)
                        {
                            System.Console.WriteLine("El resultado debe ser numerico");
                            y--;
                        }
                    }
                }
        static void generateStackValues(Queue Queue1, int limit)
        {
            Random RNumber = new Random();
            for(int i = 0; i < limit; i++)
            {
                Queue1.Enqueue(RNumber.Next(1,10));
            }
        }
        static void QueueToStack(Queue Numbers, Stack FinalStack)
        {
            foreach (var item in Numbers)
            {
                FinalStack.Push(item);
            }
            Numbers.Clear();
        }
        static void printQueueValues(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
        static void printStackValues(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
