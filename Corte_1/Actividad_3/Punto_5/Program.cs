using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i = 0, maxValue = 0, minValue = 0;
            int[] Snumber = new int[4];
            Console.WriteLine("Escribe un numero de cuatro cifras");
            number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                Snumber[i] = number%10;
                number = number / 10;
                i++;
            }
            int option;
            do
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("1. La cifra mayor dentro del numero");
                Console.WriteLine("2. La cifra menor dentro del numero");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        if(
                        Snumber[0] > Snumber[1] &&
                        Snumber[0] > Snumber[2] &&
                        Snumber[0] > Snumber[3])
                        {
                            maxValue = Snumber[0];
                        }
                        if(
                        Snumber[1] > Snumber[0] &&
                        Snumber[1] > Snumber[2] &&
                        Snumber[1] > Snumber[3])
                        {
                            maxValue = Snumber[1];
                        }
                        if(
                        Snumber[2] > Snumber[0] &&
                        Snumber[2] > Snumber[1] &&
                        Snumber[2] > Snumber[3])
                        {
                            maxValue = Snumber[2];
                        }
                        if(
                        Snumber[3] > Snumber[1] &&
                        Snumber[3] > Snumber[2] &&
                        Snumber[3] > Snumber[0])
                        {
                            maxValue = Snumber[3];
                        }
                        Console.WriteLine("");
                        Console.WriteLine("La mayor cifra es {0}",maxValue);
                        Console.WriteLine("");
                    break;
                    case 2:
                        if(
                        Snumber[0] < Snumber[1] &&
                        Snumber[0] < Snumber[2] &&
                        Snumber[0] < Snumber[3])
                        {
                            minValue = Snumber[0];
                        }
                        if(
                        Snumber[1] < Snumber[0] &&
                        Snumber[1] < Snumber[2] &&
                        Snumber[1] < Snumber[3])
                        {
                            minValue = Snumber[1];
                        }
                        if(
                        Snumber[2] < Snumber[0] &&
                        Snumber[2] < Snumber[1] &&
                        Snumber[2] < Snumber[3])
                        {
                            minValue = Snumber[2];
                        }
                        if(
                        Snumber[3] < Snumber[1] &&
                        Snumber[3] < Snumber[2] &&
                        Snumber[3] < Snumber[0])
                        {
                            minValue = Snumber[3];
                        }
                        Console.WriteLine("");
                        Console.WriteLine("La menor cifra es {0}",minValue);
                        Console.WriteLine("");
                    break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Saliendo");
                        Console.WriteLine("");
                    break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Escoge una opcion valida");
                        Console.WriteLine("");
                    break;
                }
            
            } while (option != 3);
        }
    }
}
