using System;
using System.Collections;
namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack NumberStack = new Stack();
            Stack FinalStack = new Stack();
            int Total = requestStackLength();
            requestNumbers(NumberStack, Total);
            requestNumbers(FinalStack, Total);
            moveStackItems(NumberStack, FinalStack);
            showFinalstack(NumberStack, FinalStack);
        }
        static int requestStackLength()
        {
            int Total = new int();
            do
            {
                try
                {
                    Console.Write("Escribe el limite de la pila: ");
                    Total = int.Parse(System.Console.ReadLine()); 
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("El valor ingresado debe ser numerico");
                    requestStackLength();
                }
            }while(Total < 0);
            return Total;
        }
        static void requestNumbers(Stack Numbers, int Total)
        {
            Random RNumber = new Random();
            for(int y = 0; y < Total; y++)
            {
                Console.Write($"\nEscribe el numero {y + 1}: ");
                int Value = int.Parse(System.Console.ReadLine());
                Numbers.Push(Value);
            }
        }
        static void moveStackItems(Stack NumberStack,Stack Finalstack)
        {
            foreach (var item in NumberStack)
            {
                Finalstack.Push(item);
            }
            NumberStack.Clear();
        }
        static void showFinalstack(Stack NumberStack, Stack FinalStack)
        {
            Console.WriteLine($"El stack original tiene {NumberStack.Count} datos y el final tiene {FinalStack.Count}");
            foreach (var item in FinalStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
