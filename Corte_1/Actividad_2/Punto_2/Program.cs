using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int positiveCount = 0, negativeCount = 0,positiveplus = 0, negativeplus = 0;
            for(int i  = 0; i <= 9; i++)
            {
                Console.WriteLine("Escribe un numero {0}: ", (i + 1));
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
                if(Numbers[i] % 2 == 0)
                {
                    positiveCount = positiveCount + 1;
					positiveplus = positiveplus + Numbers[i];
                }
                else
                {
                    negativeCount = negativeCount + 1;
					negativeplus = negativeplus + Numbers[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Hay {0} numeros pares y el total es {1}", positiveCount, positiveplus);
            Console.WriteLine("Hay {0} numeros impares y el total es {1}", negativeCount, negativeplus);   
        }
    }
}
