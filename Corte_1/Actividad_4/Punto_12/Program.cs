using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Agenda = new List<string>();
            ChooseOption(Agenda);
        }

        static void ChooseOption(List<string> Agenda)
        {
            int option;
            Console.WriteLine("¿Que quieres hacer?");
            Console.WriteLine("1. Agrega una nota");
            Console.WriteLine("2. Mostrar la agenda completa");
            Console.WriteLine("3. Salir");
            Console.Write("Elije una opcion: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch(option)
            {
                case 1:
                    addNote(Agenda);
                break;
                case 2:
                    ShowAgenda(Agenda);
                break;
                case 3:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Elije una opcion valida");
                break;
            }
        }

        static void addNote(List<string> Note)
        {
            DateTime hour = DateTime.Now;
            string year, month, day, note;
            int nday, nMonth, nYear;
            do
            {
                Console.WriteLine("Escribe el dia");
                day = Convert.ToString(Console.ReadLine());
                nday = Int32.Parse(day);
                if(nday < 1 || nday > 31)
                {
                    Console.WriteLine("Escribe un dia valido");
                }
            }while(nday < 1 || nday > 31);
            
            do
            {
                Console.WriteLine("Escribe el mes");
                month = Convert.ToString(Console.ReadLine());
                nMonth = Int32.Parse(month);
                if(nMonth < 1 || nMonth > 12)
                {
                    Console.WriteLine("Escribe un mes valido");
                }
            }while(nMonth < 1 || nMonth > 31);
            
            do
            {
                Console.WriteLine("Escribe el año");
                year = Convert.ToString(Console.ReadLine());
                nYear = Int32.Parse(year);
                if(nYear < 2021)
                {
                    Console.WriteLine("Escribe un año valido");
                }
            }while(nYear < 2021);

            Console.WriteLine("Escribe la nota que quieras agregar");
            note = Convert.ToString(Console.ReadLine());
            Note.Add(year + "/" + month + "/" + day + " " + hour.ToShortTimeString() + "\n" + note);
            ChooseOption(Note);
        }

        static void ShowAgenda(List<string> Agenda)
        {
            for(int i = 0; i < Agenda.Count; i++)
            {
                Console.WriteLine(Agenda[i]);
                Console.WriteLine("");
            }
            ChooseOption(Agenda);
        }
    }
}