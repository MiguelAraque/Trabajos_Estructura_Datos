using System;
using System.Collections;
namespace Punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Numbers = new Stack();
            Stack FinalNumber = new Stack();
            Console.Write("Escribe el total de numeros en la pila: ");
            int limit = int.Parse(System.Console.ReadLine());
            requestNumbers(Numbers, limit);
            ArrayList TempValues = new ArrayList();
            stackTransfer(Numbers, FinalNumber, TempValues);
            showStack(Numbers, FinalNumber);
        }
        static void requestNumbers(Stack Numbers, int limit)
        {
            Random RandomNumber  = new Random();
            for(int i = 0; i < limit; i++)
            {
                Console.Write($"Escribe el numero {i + 1}: ");
                Numbers.Push(Console.ReadLine());            
            }
            Console.WriteLine("");
        }
        static void stackTransfer(Stack oldStack, Stack newStack, ArrayList TempValues)
        {
            foreach (var item in oldStack)
            {
                TempValues.Add(item);
            }
            TempValues.Reverse();
            foreach (var item in oldStack)
            {
                newStack.Push(item);
            }
            oldStack.Clear();
        }
        static void showStack(Stack oldStack, Stack newStack)
        {
            Console.WriteLine($"En la pila 1 hay {oldStack.Count} datos y en la nueva pila hay {newStack.Count} datos");
            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
