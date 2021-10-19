using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            try
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("1. Saber la posición de una letra en una palabra");
                Console.WriteLine("2. Pasar las palabras a mayusculas");
                Console.WriteLine("3. Reemplazar uno o más caracteres de una cadena");
                int option = int.Parse(System.Console.ReadLine());
                switch(option)
                {
                    case 1:
                        findLetterPosition();
                    break;
                    case 2:
                        ConvertToUpperWord();
                    break;
                    case 3:
                        ReplaceLetters();
                    break;
                    default:
                        Console.WriteLine("Elige una opción valida, ¡vuelve a intentarlo!");
                        Menu();
                    break;
                }   
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser numerico, ¡vuelve a intentarlo!");
                Console.Write("Presione una tecla para continuar: ");
                Console.ReadKey();
                Menu();                
            }
        }
        static void findLetterPosition()
        {
            try
            {
                Console.Write("Escribe la palabra: ");
                String Word = Console.ReadLine();
                Console.Write("Escribe la letra a buscar: ");
                Char letter = Convert.ToChar(Console.ReadLine());
                int Counter = Word.IndexOf(letter);
                if(Counter < 0)
                {
                    Console.WriteLine($"La letra {letter} no se encuentra en la palabra {Word}");
                    Console.WriteLine("Volviendo al menu, presione una tecla para continuar");
                    Console.ReadKey();
                    Menu();
                }
                else
                {
                    Console.WriteLine($"La letra {letter} se encuentra en la posición {Counter + 1}");
                    Console.WriteLine("Volviendo al menu, presione una tecla para continuar");
                    Console.ReadKey();
                    Menu();
                }     
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser alfabetico, volviendo al menu");
                Menu();
            }
        }
        static void ConvertToUpperWord()
        {
            try
            {
                Console.Write("Escribe la palabra: ");
                String Word = Console.ReadLine();
                String Converted = Word.ToUpper();
                Console.WriteLine($"la palabra {Word} queda como {Converted}");     
            }
            catch (System.Exception)
            {
                Console.WriteLine("El valor ingresado debe ser alfabetico, volviendo al menu");
                Menu();
                throw;
            }            
        }
        static void ReplaceLetters()
        {
            try
            {
                Console.Write("Escribe la palabra: ");
                String Word = Console.ReadLine();
                Console.Write("¿Que caracter desea reemplazar?: ");
                Char oldLetter = Convert.ToChar(Console.ReadLine());
                Console.Write("¿Que caracter desea intercambiar?: ");
                Char newLetter = Convert.ToChar(System.Console.ReadLine());
                Console.Write($"la palabra {Word} queda");
                String Converted = Word.Replace(oldLetter, newLetter);
                Console.Write($"\n {Converted}");     
            }
            catch (System.Exception)
            {
                Console.WriteLine("El valor ingresado debe ser alfabetico, volviendo al menu");
                Menu();
                throw;
            }
        }
    }
}
