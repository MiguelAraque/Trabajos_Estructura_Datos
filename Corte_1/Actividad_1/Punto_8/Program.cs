using System;

namespace Punto_8
{
    class vocalScanner
    {
        static void Main(string[] args)
        {
            Char Letter;
            Console.WriteLine("Escribe una letra");
            Letter = Convert.ToChar(Console.ReadLine());
            if (char. IsLower(Letter))
            {
                Console.WriteLine("{0} es una letra minuscula", Letter);
            }
            String i = Convert.ToString(Letter);
            if(i == "A" || i == "a" || i == "E" || i == "e" || i == "I" || i == "i" || i == "O" || i == "o" || i == "U" || i == "u")
            {
               Console.WriteLine("{0} es una vocal", Letter); 
            }
            if(char.IsLetter(Letter))
            {
                Console.WriteLine("{0} es un simbolo del alfabeto", Letter);
            }
        }
    }
}
