using System;
using System.Text;
using System.Threading;
namespace ActividadVIII
{
    class StringBuilderExercises
    {
        public static void Menu()
        {
            StringBuilder Word = new StringBuilder();
            Console.WriteLine("Ejercicios con StringBuilder");
            Console.WriteLine("1. Append \t 3. AppendFormat");
            Console.WriteLine("2. WriteLine \t 4. ToString");
            Console.WriteLine("\t 5. Volver al menu principal");
            Console.Write("Elige una opción: ");
            int option = int.Parse(System.Console.ReadLine());
            switch (option)
            {
                case 1:
                    Word.AppendFormat("Primera linea"); 
                    Word.AppendFormat("Segunda linea");
                    Console.Write(Word);
                    Thread.Sleep(2000);
                    StringBuilderExercises.Menu();
                break;
                case 2:                    
                    Word.AppendFormat("Primera linea"); 
                    Word.AppendFormat("Segunda linea");
                    Console.WriteLine(Word);
                    Thread.Sleep(2000);
                    StringBuilderExercises.Menu();
                break;
                case 3: 
                    Word.AppendFormat("Primera linea"); 
                    Word.AppendFormat("Segunda linea");
                    Console.WriteLine(Word);
                    Thread.Sleep(2000);
                    StringBuilderExercises.Menu();
                break;
                case 4:
                    Word.Append("Primera linea"); 
                    Word.Append("Segunda linea");
                    String SWord = Word.ToString();
                    Console.WriteLine(SWord);
                    Thread.Sleep(2000);
                    StringBuilderExercises.Menu();
                break;
                case 5:
                    MainMenu.Main();
                break;
                default:

                break;
            }
        }
    }
}