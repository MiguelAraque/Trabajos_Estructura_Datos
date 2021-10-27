using System;

namespace ActividadVIII
{
    class MainMenu
    {
        public static void Main()
        {
            MainMenu.requestOption();           
        }
        public static void requestOption()
        {
            int option;
            try
            {
                Console.WriteLine("Puntos Actividad VIII");
                Console.WriteLine("1. Object");
                Console.WriteLine("2. Date");
                Console.WriteLine("3. String");
                Console.WriteLine("4. StringBuilder");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");
                option = int.Parse(System.Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ObjectExersices.Menu();
                    break;
                    case 2:
                        DateExercices.Menu();
                    break;
                    case 3:
                        StringExercises.Menu();
                    break;
                    case 4:
                        StringBuilderExercises.Menu();
                    break;
                    case 5:
                        Environment.Exit(0);
                    break;
                    default:
                    
                    Console.WriteLine("Elige una opción valida");
                    
                    break;
                }
            }
            catch (System.FormatException)
            {
                
            }
        }
    }
}
