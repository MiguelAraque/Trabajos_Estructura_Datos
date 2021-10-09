using System;
using System.Collections;
namespace Punto7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Stack1 = new Stack();
            Stack Stack2 = new Stack();
            floatNumbersToStack(Stack1, 3);
            floatNumbersToStack(Stack2, 3);
            StackToStack(Stack1, Stack2);
            Console.WriteLine($"La primera pila tiene {Stack1.Count} datos ");
            Console.WriteLine($"la segunda tiene {Stack2.Count} datos");
            Console.WriteLine($"La pila resultante tiene: {StackToStack(Stack1, Stack2).Count} datos");
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
        static Stack StackToStack(Stack Stack1, Stack Stack2)
        {
            Stack FinalStack = new Stack();
            foreach (float item in Stack1)
            {
                FinalStack.Push(item);
            }
            foreach (float item in Stack2)
            {
                FinalStack.Push(item);
            }
            return FinalStack;
        }
    }
}
