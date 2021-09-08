using System;
using System.Text.RegularExpressions;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWord, allCounter = string.Empty;
            int vocalCounter = 0, ConsonantCounter = 0, numberCounter;
            Console.WriteLine("Escribe la palabra");
            userWord = Console.ReadLine();
            userWord = userWord.ToLower();
            Match number = Regex.Match(userWord, "(\\d+)");
            for(int i = 0; i < userWord.Length; i++)
            {
                if(userWord.Substring(i, 1) == "a" || userWord.Substring(i, 1) == "e" || userWord.Substring(i, 1) == "i" || userWord.Substring(i, 1) == "o" || userWord.Substring(i, 1) == "u")
                {
                    vocalCounter = vocalCounter + 1;
                }
                else
                {
                    ConsonantCounter = ConsonantCounter + 1;
                }
            }
            if(number.Success)
            {
                allCounter = number.Value;
            }
            numberCounter = allCounter.Length;
            ConsonantCounter = ConsonantCounter - numberCounter;
            Console.WriteLine("");
            Console.WriteLine("La palabra {0} tiene {1} vocales, {2} consonantes y {3} numeros",userWord, vocalCounter, ConsonantCounter, numberCounter);
        }
    }
}
