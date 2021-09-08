using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            int start, end;
            Console.WriteLine("Escribe el primer numero");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero");
            end = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("i. Mostrar numeros pares entre {0} y {1}", start, end);
                Console.WriteLine("p. Mostrar numeros inpares entre {0} y {1}", start, end);
                Console.Write("Elige una opcion: ");
                option = Convert.ToChar(Console.ReadLine());
                char.ToLower(option);
                switch (option)
                {
                    case 'i':
                        Program.unpairNumbers(start, end);
                    break;
                    case 'p':
                        Program.pairNumbers(start, end);
                    break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Escoge una opcion valida");
                        Console.WriteLine("");
                    break;
                }   
            }while(option != 'i' && option != 'o');   
        }
        static void pairNumbers(int start, int end)
        {
            int Counter = 0;
            for(int i = start;i < end; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                    Counter++;
                }
            }
            Console.WriteLine("Hay {0} numeros pares entre {1} y {2}", Counter, start, end);
        }
        static void unpairNumbers(int start, int end)
        {
            int Counter = 0;
            for(int i = start; i < end; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Counter++;
                }
            }
            Console.WriteLine("Hay {0} numeros inpares entre {1} y {2}", Counter, start, end);
        }
    }
}
