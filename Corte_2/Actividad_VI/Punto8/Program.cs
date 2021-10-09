using System;
using System.Collections;

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack oldStack = new Stack();
            Stack newStack = new Stack();
            try
            {
                Console.Write("Escribe la cantidad de numeros de las pilas: ");
                int limit = int.Parse(System.Console.ReadLine());
                requestStackValues(oldStack, limit);
                requestStackValues(newStack, limit);
                swapStacks(oldStack, newStack);
                showNumbers(oldStack, newStack);                 
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico");
            }
        }
        static void requestStackValues(Stack Numbers, int limit)
        {
            for(int y = 0; y < limit; y++)
            {
                try
                {
                    Console.Write($"Escribe el numero {(y + 1)}: ");
                    Numbers.Push(int.Parse(System.Console.ReadLine()));
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("El resultado debe ser numerico");
                    y--;
                }
            }
        }
        static void swapStacks(Stack stack1, Stack stack2)
        {
            int[] Tempstack1 = new int[stack1.Count];
            int[] Tempstack2 = new int[stack2.Count];
            int i = 0;
            foreach(int item in stack1)
            {
                Tempstack1[i] = item;
                i++;
            }
            i = 0;
            foreach(int item in stack2)
            {
                Tempstack2[i] = item;
                i++;
            }
            stack1.Clear();
            stack2.Clear();
            for(int y = 0; y < Tempstack1.Length; y++)
            {
                stack2.Push(Tempstack1[y]);
                stack1.Push(Tempstack2[y]);
            }
        }    
        static void showNumbers(Stack stack1, Stack stack2)
        {
            Console.WriteLine("Pila 1");
            foreach (var item in stack1)
            {
                Console.Write("\t {0}", item);
            }
            Console.Write("\n");
            Console.WriteLine("Pila 2");
            foreach (var item in stack2)
            {
                Console.Write("\t {0}", item);
            }
        }       
    }
}

