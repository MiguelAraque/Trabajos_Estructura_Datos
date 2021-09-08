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
            Console.WriteLine("Escribe el numero");
            int Limit = Convert.ToInt32(Console.ReadLine());
            int[] numberList = new int[Limit];
            PrimeNumberGenerator(numberList);
            showList(numberList);
            Console.WriteLine("El numero primo más grande es el {0} y el menor es {1}", maxNumber(numberList), minNumber(numberList));
    
        }
        public static void PrimeNumberGenerator(int[] numberList)
        {
            int i = 0;
            Random randomNumber = new Random();
            while(i < numberList.Length)
            {
                int num = randomNumber.Next(1, 100);           
                if (primeValidator(num))
                {              
                    numberList[i] = num;               
                    i++;
                }            
            }       
        }
        private static Boolean primeValidator (int num)
        {            
                int prueba;         
                int contador = 0;
                prueba = (int) Math.Sqrt(num);

                for (;prueba > 1; prueba--)
                {
                    if (num % prueba == 0)
                    {
                        contador += 1;
                    }
                }
                return contador < 1;
        }
        public static void showList(int[] numberList)
        {
            for(int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("{0}. {1}",(i + 1), numberList[i]);
            }
        }
        public static int maxNumber(int[] numberList)
        {
            int max=0;
            for(int i = 0; i < numberList.Length; i++)
            {
                if(numberList[i]>max)
                {
                    max=numberList[i];
                }
            }
            return max;
        }
        public static int minNumber(int[] numberList)
        {
            int min = 999;
            for(int i = 0; i < numberList.Length; i++)
            {
                if(numberList[i] < min)
                {
                    min = numberList[i];
                }
            }
            return min;
        }     
    }
}
