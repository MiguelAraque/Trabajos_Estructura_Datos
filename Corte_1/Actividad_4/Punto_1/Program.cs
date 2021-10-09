using System;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp;
            double[] Numbers = new double[15];
            Program.RequestNumbers(Numbers);
            exp = Program.requestSecondNumber();
            Program.showOperations(Numbers, exp);


        }
        static void RequestNumbers(double [] Numbers)
        {
            for(int i = 0; i <= 14; i++)
            {
                Console.WriteLine("Escribe el numero {0}", (i+1));
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int requestSecondNumber()
        {
            int exp;
            Console.WriteLine("Escribe el numero para hacer las operaciones");
            exp = Convert.ToInt32(Console.ReadLine());
            return exp;
        }
        static void showOperations(double [] Numbers, int exp)
        {
            for(int i = 0; i < Numbers.Length; i++)
            {
                double Mul = Numbers[i] * exp;
                double Div = Numbers[i] / exp;
                Console.Write("Numero {0}: \n Multipliación: {1} \n Division: {2} \n", Numbers[i], Mul, Div);
            }
        }
         
    }
}
