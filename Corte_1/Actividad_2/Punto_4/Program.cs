using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int option = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Escribe el numero {0}: ", (i + 1));
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("");
                Console.WriteLine("1. Organizar de mayor a menor");
                Console.WriteLine("2. Organizar de menor a mayor");
                Console.WriteLine("3. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elige una opción: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1: 
                        Array.Sort(numbers);
                        Array.Reverse(numbers);
                        foreach(int value in numbers)
                        {
                            Console.WriteLine(value);
                            Console.Write(" ");
                        }
                    break;
                    case 2:
                        Array.Sort(numbers);
                        foreach(int value in numbers)
                        {
                            Console.WriteLine(value);
                            Console.Write(" ");
                        }
                    break;
                }
            }while(option != 3);
        }
    }
}
