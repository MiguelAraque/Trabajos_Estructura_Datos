using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Escribe el numero {0}", (i + 1));
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            for(int i = 0; i <= 4; i++)
            {
                Console.Write(Numbers[i]+" ");
                for(int astherisk = 0; astherisk != Numbers[i]; astherisk++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}
