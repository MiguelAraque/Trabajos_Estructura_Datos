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
            int[] NumberList = new int[100];
            Program.numberGenerator(NumberList);
            Console.WriteLine("La suma de todos los numeros es {0} y la media es {1}", Program.NumberListSum(NumberList), Program.numberListAverage(NumberList));
        }
        static void numberGenerator(int[] numberList)
        {
            Random RandomNumber = new Random();
            for(int i = 0; i < numberList.Length; i++)
            {
                numberList[i] = RandomNumber.Next(1, 100);
                Console.WriteLine(numberList[i]);
            }
        }
        static int NumberListSum(int[] numberList)
        {
            int Total = 0;
            for(int i = 0; i < numberList.Length; i++)
            {
                Total += numberList[i];
            }
            return Total;
        }
        static int numberListAverage(int[] numberList)
        {
            int Average;
            Average = Program.NumberListSum(numberList) / numberList.Length;
            return Average;
        }
    }
}
