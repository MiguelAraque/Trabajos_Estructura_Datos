using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            do
            {
                Console.WriteLine("Escribe el numero");
                limit = Convert.ToInt32(Console.ReadLine());
                if (limit < 100 || limit > 200)
                {
                    Console.WriteLine("El numero debe ser mayor de 100 y menor de 200");
                }
                else
                {
                    while(limit != 200)
                    {
                        if(limit %2 == 0)
                        {
                            Console.WriteLine(limit);
                        }
                    limit++;
                    }
                }
            } while (limit < 100 || limit > 200);

        }
    }
}
