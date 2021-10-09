using System;
using System.Collections;
namespace Punto9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Numbers = new Stack();
            requestStackValues(Numbers, 3);
            Console.WriteLine("stack original");
            
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("stack clonado");
            foreach (var item in cloneStack(Numbers))
            {
                Console.WriteLine(item);
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
        static Stack cloneStack(Stack Numbers)
        {
            Stack Clonedstack = new Stack();
            ArrayList TempStack = new ArrayList();
            
            foreach (int item in Numbers)
            {
                TempStack.Add(item);
            }
            TempStack.Reverse();
            foreach (var item in TempStack)
            {
                Clonedstack.Push(item);
            }
            return Clonedstack;
        }
        
    }
}
