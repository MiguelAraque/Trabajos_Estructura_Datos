using System;
using System.Threading;
namespace ActividadVIII
{
    public class DateExercices
    {
        public static void Menu()
        {
            Console.WriteLine("");
            try
            {
                DateTime actualTime = DateTime.Today;
                int actualDay = actualTime.Day;
                int actualMonth = actualTime.Month;
                int actualYear = actualTime.Year;
                int userDay, userMonth, userYear;
                int userAge;
                Console.WriteLine("Ejercicio");
                Console.WriteLine("Saber la edad de una persona");
                Console.WriteLine("Escribe la fecha de nacimiento");
                Console.Write("Dia: ");
                userDay = int.Parse(System.Console.ReadLine());
                Console.Write("Mes: ");
                userMonth = int.Parse(System.Console.ReadLine());
                Console.Write("Año: ");
                userYear = int.Parse(System.Console.ReadLine());
                userAge = actualYear - userYear;
                if(userDay > actualDay && userMonth > actualMonth)
                {
                    userAge++;
                } 
                Console.WriteLine($"la edad de la persona es: {userAge} \npresione un boton para volver al menu");
                Console.ReadKey();
                MainMenu.Main();    
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El dato ingresado debe ser numerico");
                Console.Write("Presione una tecla para continuar");
                Console.ReadKey();
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(1500);
            }
            
        }
    }
}