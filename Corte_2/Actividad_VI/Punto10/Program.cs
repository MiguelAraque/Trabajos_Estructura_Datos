using System;
using System.Collections;
namespace Punto10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Numbers = new Stack();
            floatNumbersToStack(Numbers, 3);
            Console.WriteLine("Primero");
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Segundo");
            foreach (var item in StackToStack(Numbers))
            {
                Console.WriteLine(item);
            }

        }
        static void floatNumbersToStack(Stack Numbers, int limit)
        {
            Random rand = new Random();
            for(int i = 0; i < limit; i++)
            {
                float randomFloat = (float)rand.NextDouble();
                Numbers.Push(randomFloat);
            }
        }
        static Stack StackToStack(Stack Numbers)
        {
            ArrayList TempStack = new ArrayList();
            Stack FinalStack = new Stack();
            foreach (var item in Numbers)
            {
                TempStack.Add(item);
            }
            foreach (var item in TempStack)
            {
                FinalStack.Push(item);
            }
            return FinalStack;
        }
    }
}
