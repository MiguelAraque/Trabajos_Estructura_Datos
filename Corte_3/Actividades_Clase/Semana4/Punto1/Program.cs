using System;
using System.Collections;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList CharacterList = new ArrayList();
            loadArrayList(CharacterList, 5);
            String[] UpperList = new String[CharacterList.Count];
            String[] LowerList = new String[CharacterList.Count];
            ConvertToUpperCharacter(CharacterList, UpperList);
            ConvertToLowerCharacter(CharacterList, LowerList);
            printArrayValues(UpperList, "Mayusculas");
            printArrayValues(LowerList, "Minusculas");
        }
        static void loadArrayList(ArrayList CharacterList, int limit)
        {
            for(int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Escribe la cadena {i + 1}");
                CharacterList.Add(Convert.ToString(System.Console.ReadLine()));
            }
        }
        static void ConvertToUpperCharacter(ArrayList CharacterList, String[] UpperList)
        {
            int i = 0;
            foreach (String item in CharacterList)
            {
                String TempItem = item.ToUpper();
                UpperList[i] = TempItem;
                i++;
            }
        }
        static void ConvertToLowerCharacter(ArrayList CharacterList, String[] LowerList)
        {
            int i = 0;
            foreach (String item in CharacterList)
            {
                String TempItem = item.ToLower();
                LowerList[i] = TempItem;
                i++;
            }
        }
        static void printArrayValues(String[] List, String Title)
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
