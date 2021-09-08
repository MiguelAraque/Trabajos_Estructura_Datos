using System;
using System.Text.RegularExpressions;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            double result;
            Console.WriteLine("¿Que quieres hacer?");
            Console.WriteLine("T = Calcular el area de un triangulo");
            Console.WriteLine("C = Calcular el area de un circulo");
            Console.WriteLine("Elige una opcion: ");
            option = Console.ReadLine();
            option = option.ToLower();
            switch(option)
            {
                case "t":
                    double bases;
                    double height;
                    Console.WriteLine("Escribe la base del triangulo");
                    bases = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe la altura del triangulo");
                    height = Convert.ToInt32(Console.ReadLine());
                    result = (bases * height) / 2;
                    Console.WriteLine("");
                    Console.WriteLine("El area del triangulo es {0}", result);
                break;
                case "c":
                    double radius;
                    Console.WriteLine("Escribe el radio del circulo");
                    radius = Convert.ToInt32(Console.ReadLine());
                    result = radius * radius;
                    result = result * Math.PI;
                    result = Math.Round(result, 2);
                    Console.WriteLine("");
                    Console.WriteLine("El area del circulo es {0}", result);
                break;
                default:
                    Console.WriteLine("Elige una opcion valida");
                break;
            }
        }
    }
}
