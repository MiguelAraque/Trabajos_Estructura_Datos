using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] lowerWords = new String[5];
            String[] UpperWords = new String[5];
            loadArray(lowerWords);
            ConvertToUpperWord(lowerWords, UpperWords);
            Console.WriteLine("Vector en minuscula");
            printArrayValues(lowerWords);
            Console.WriteLine("Vector en mayuscula");
            printArrayValues(UpperWords);

        }
        static void loadArray(String[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Escribe la palabra N° {0}", (i + 1));
                Array[i] = Convert.ToString(Console.ReadLine());
            }
        }
        static void ConvertToUpperWord(String[] lowerWords, String[] UpperWords)
        {
            for(int i = 0; i < lowerWords.Length; i++)
            {
                UpperWords[i] = lowerWords[i].ToUpper();
            }
        }
        static void printArrayValues(String[] Array)
        {
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
        }        
    }
}
