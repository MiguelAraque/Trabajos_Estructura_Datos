using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList CharacterList = new ArrayList();
            Queue FirstLetters = new Queue();
            loadArrayList(CharacterList, 2);
            extractFirstLetter(CharacterList, FirstLetters);
            printQueueValues(FirstLetters, "primeros 4 valores");
        }
        static void loadArrayList(ArrayList CharacterList, int limit)
        {
            for(int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Escribe la cadena {i + 1}");
                CharacterList.Add(Convert.ToString(System.Console.ReadLine()));
            }
        }
        static void extractFirstLetter(ArrayList CharacterList, Queue FirstLetter)
        {
            foreach (String item in CharacterList)
            {
                String newItem = Regex.Replace(item, @"\s", "");
                Char[] TempItem = newItem.ToCharArray();
                string FirstLetters = "";
                int LIMIT = 4;
                for (int i = 0; i < LIMIT; i++)
                {
                    FirstLetters += Convert.ToString(TempItem[i]);
                }
                FirstLetter.Enqueue(FirstLetters);
            }
        }
        static void printQueueValues(Queue List, String Title)
        {
            Console.WriteLine(Title);
            foreach (String item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
