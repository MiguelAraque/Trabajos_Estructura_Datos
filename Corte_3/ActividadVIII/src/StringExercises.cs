using System;
using System.Threading;
namespace ActividadVIII
{
    class StringExercises
    {
        public static void Menu()
        {
            try
            {
                Thread.Sleep(2000);
                Console.WriteLine("Ejericicios con la clase String");
                Console.WriteLine("1. Concat \t 2. Compare \t 3. Equals \t 4. Contains");
                Console.WriteLine("5. Substring \t 6. EndsWith \t 7. CopyTo \t 8. Insert");
                Console.WriteLine("9. LastIndexOf \t 10. PadLeft \t 11. PadRight \t 12. Remove");
                Console.WriteLine("13. Replace \t 14. Split \t 15. ToLower \t 16. ToUpper");
                Console.WriteLine("17. Trim \t 18. TrimStart \t 19. TrimEnd \t 20. Volver al menu principal");
                Console.Write("Elige una opción: ");
                int option = int.Parse(System.Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Concat();
                    break;
                    case 2:
                        Compare();
                    break;
                    case 3:
                        Equals();
                    break;
                    case 4:
                        Contains();
                    break;   
                    case 5:
                        //Substring
                        SubString();
                    break;
                    case 6:
                        //EndsWith
                        EndsWith();
                    break;
                    case 7:
                        //CopyTo
                        CopyTo();
                    break;
                    case 8:
                        //Insert
                        Insert();
                    break;
                    case 9:
                        //LastIndexOf
                        LastIndexOf();
                    break;
                    case 10:
                        //PadLeft
                        PadLeft();
                    break;
                    case 11:
                        //PadRight
                        PadRight();
                    break;
                    case 12:
                        //Remove
                        Remove();
                    break;
                    case 13:
                        //Replace
                        Replace();
                    break;
                    case 14:
                        //Split
                        Split();
                    break;
                    case 15:
                        //ToLower
                        ToLower();
                    break;
                    case 16:
                        //ToUpper
                        ToUpper();
                    break;
                    case 17:
                        //Trim
                        Trim();
                    break;
                    case 18:
                        //TrimStart
                        TrimStart();
                    break;
                    case 19:
                        //TrimEnd
                        TrimEnd();
                    break;
                    case 20:
                        MainMenu.Main();
                    break;
                    default:
                        Console.WriteLine("Elige una opción valida");
                        StringExercises.Menu();
                    break;
                }
            }
            catch (System.FormatException)
            {
                
            }
        }
        static void Concat()
        {
            Console.Write("Escribe la primera frase: ");
                String Word1 = Convert.ToString(System.Console.ReadLine());
                Console.Write("Escribe la segunda frase: ");
                String Word2 = Convert.ToString(System.Console.ReadLine());
            String FinalWord;
            Console.WriteLine("Funcion: Unir 2 cadenas de texto a una sola");
            Thread.Sleep(2000);
            FinalWord = String.Concat(Word1, " " ,Word2);
            Console.WriteLine($"La palabra queda asi: \n{FinalWord}");
            StringExercises.Menu();
        }
        static void Compare()
        {
            Console.Write("Escribe la primera frase: ");
            String Word1 = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la segunda frase: ");
            String Word2 = Convert.ToString(System.Console.ReadLine());
            Console.WriteLine("Funcion: Comparar 2 valores y saber si son iguales");
            Thread.Sleep(2000);
            int w3 = String.Compare(Word1, Word2);
            if(w3 < 0)
            {
                Console.WriteLine("las dos frases no son iguales");
            }
            else
            {
                Console.WriteLine("Las dos frases son iguales");
            }
        }
        static void Equals()
        {
            Console.WriteLine("Funcion: Equals compara variables");
            Thread.Sleep(2000);
            Console.Write("Escribe la primera palabra: ");
            String Word1 = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la segunda palabra: ");
            String Word2 = Convert.ToString(System.Console.ReadLine());
            if(Word1.Equals(Word2))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }
        }
        static void Contains()
        {
            char letter;
            Console.Write("¿Cual palabra desea usar?: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("¿Que letra desea buscar?: ");
            letter = Convert.ToChar(System.Console.ReadLine());
            if(Word.Contains(letter))
            {
                Console.WriteLine($"la palabra {Word} SI contiene la letra {letter}");
            }
            else
            {
                Console.WriteLine($"la palabra {Word} NO contiene la letra {letter}");
            }
                                    
        }
        static void SubString()
        {
            String Word;
            int initialPosition;
            int endPosition;
            string Substring;
            Console.Write("Escribe la palabra a usar: ");
            Word = Convert.ToString(System.Console.ReadLine());
            int option = int.Parse(System.Console.ReadLine());
            Console.Write("escribe la posicion inicial: ");
            initialPosition = int.Parse(System.Console.ReadLine());
            Console.Write("escribe la posicion final: ");
            endPosition = int.Parse(System.Console.ReadLine());
            if(initialPosition > 0)
            {
                initialPosition--;
            }
            else if(initialPosition < 0)
            {
                initialPosition = 0;
            }
            else if(endPosition < 0)
            {
                endPosition = 0;
            }
            Substring = Word.Substring(initialPosition, endPosition);
            Console.WriteLine($"La palabra {Word} queda como {Substring}");           
        }
        static void EndsWith()
        {
            //Comprobar si un texto acaba en un valor especifico
            Console.Write("Escribe la palabra a usar: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la letra: ");
            char value = Convert.ToChar(System.Console.ReadLine());
            if(Word.EndsWith(value))
            {
                Console.WriteLine($"La palabra {Word} SI termina en {value}");
            }
            else
            {
                Console.WriteLine($"La palabra {Word} NO termina en {value}");
            }
        }
        static void CopyTo()
        {
            Console.Write("Escribe la cantidad total de valores: ");
            int limit = int.Parse(System.Console.ReadLine());
            string[] Example = new string[limit];
            for(int i = 0; i < limit; i++)
            {
                Console.Write($"Escribe el valor {i + 1}: ");
                Example[i] = Convert.ToString(System.Console.ReadLine());
            }
            string[] ClonedExample = new string[Example.Length];
            Example.CopyTo(ClonedExample, 0);
            Console.WriteLine($"{Example.Length} {ClonedExample.Length}");
        }
        static void Insert()
        {
            Console.Write("Escribe la palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe lo que vas a agregar: ");
            String add = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe el punto donde lo quieras agregar(valor numerico): ");
            int Position = int.Parse(System.Console.ReadLine());
            Console.Write($"La palabra {Word} queda como: ");
            Word = Word.Insert(Position, add);
            Console.Write(Word);

        }
        static void LastIndexOf()
        {
            //Buscar valor de derecha a izquierda 
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la palabra a usar: ");
            char value = Convert.ToChar(System.Console.ReadLine());
            Console.Write($"La letra {value} esta en la posición {Word.LastIndexOf(value) + 1}");
        }
        static void PadLeft()
        {
            Console.Write("Escribe una palabra: ");
            String word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la distancia(numerico): ");
            int limit = int.Parse(System.Console.ReadLine());
            Console.Write("Con PadLeft: ");
            Console.WriteLine(word.PadLeft(limit));
            Console.Write("Sin padLeft: ");
            Console.WriteLine(word);
        }
        static void PadRight()
        {
            Console.Write("Escribe una palabra: ");
            String word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la distancia(numerico): ");
            int limit = int.Parse(System.Console.ReadLine());
            Console.Write("Con PadRight: ");
            Console.WriteLine($"{word.PadRight(limit)}!");
            Console.Write("Sin padRight: ");
            Console.WriteLine($"{word}!");
        }
        static void Remove()
        {
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la posición desde donde quieras borrar: ");
            int Position = int.Parse(System.Console.ReadLine());
            Position--;
            Word = Word.Remove(Position);
            Console.Write(Word);
        }
        static void Replace()
        {
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write("¿Cual letra quieres cambiar?: ");
            char oldLetter = Convert.ToChar(System.Console.ReadLine());
            Console.Write("¿Cual es la nueva letra?: ");
            char newLetter = Convert.ToChar(System.Console.ReadLine());
            Console.Write($"La palabra {Word} queda como: ");
            Word = Word.Replace(oldLetter, newLetter);
            Console.Write(Word);
            
        }
        static void Split()
        {
            //Separar palabras en un array;
            int i = 1;
            Console.Write("Escribe una oración: ");
            string Word = Convert.ToString(System.Console.ReadLine());
            string[] subs = Word.Split(' ', '.');
            Console.WriteLine("Resultado: ");
            foreach (var item in subs)
            {
                Console.WriteLine($"{i}. {item}");
                Thread.Sleep(1000);
                i++;
            }
        }
        static void ToLower()
        {
            //Pasar un texto a minuscula;
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write($"La palabra {Word} queda como: ");
            Word = Word.ToLower();
            Console.Write(Word);
        }
        static void ToUpper()
        {
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write($"La palabra {Word} queda como: ");
            Word = Word.ToUpper();
            Console.Write(Word);
        }
        static void Trim()
        {
            //Eliminar espacios, asteriscos y apostrofes al inicio y final de una cadena
            char[] charsToTrim = { '*', ' ', '\''};
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write($"La palabra '{Word}' queda como: '{Word.Trim()}' \n");
        }
        static void TrimStart()
        {
            //Eliminar espacios, asteriscos y apostrofes al inicio de una cadena
            char[] charsToTrim = { '*', ' ', '\''};
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write($"La palabra '{Word}' queda como: '{Word.TrimStart(charsToTrim)}' \n");
        }
        static void TrimEnd()
        {
            //Eliminar espacios, asteriscos y apostrofes final de una cadena
            char[] charsToTrim = { '*', ' '};
            Console.Write("Escribe una palabra: ");
            String Word = Convert.ToString(System.Console.ReadLine());
            Console.Write($"La palabra '{Word}' queda como: '{Word.TrimEnd(charsToTrim)}' \n");
        }
    }
}