using System;
using System.Threading;

namespace ActividadIX
{
    class Operations
    {
        public int N1;
        public int N2;
        public Operations(int Number1, int Number2)
        {
            N1 = Number1;
            N2 = Number2;
        }
        public void Calculator()
        {
            Console.WriteLine("Calculadora \n");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Elige una opción: ");
            switch (int.Parse(System.Console.ReadLine()))
            {
                case 1:
                    Addition();
                break;
                case 2:
                    Substraction();
                break;
                case 3:
                    Multiplication();
                break;
                case 4:
                    Division();
                break;
                case 5:
                    Console.Clear();
                    MainMenu.Main();
                break;
                default:

                break;
            }
        }
        public void Addition()
        {
            int Result = N1 + N2;
            Console.WriteLine($"Resultado: {Result}");
            Thread.Sleep(2000);
            Calculator();
        }
        public void Substraction()
        {
            int Result = N1 - N2;
            Console.WriteLine($"\nResultado: {Result}");
            Thread.Sleep(2000);
            Calculator();
        }
        public void Multiplication()
        {
            int Result = N1 * N2;
            Console.WriteLine($"\nResultado: {Result}");
            Thread.Sleep(2000);
            Calculator();
        }
        public void Division()
        {
            int Result = N1 / N2;
            Console.WriteLine($"\nResultado: {Result}");
            Thread.Sleep(2000);
            Calculator();
        }
    }
}