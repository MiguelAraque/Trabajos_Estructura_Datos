using System;

namespace pyramidCans
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, linea = 1, npuntos = 0;
            Console.WriteLine("Escribe un numero de latas a acomodar");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            while(npuntos < n1)
            {
                npuntos = npuntos + linea;
                linea++;
            }
            if(npuntos == n1)
            {
                Console.WriteLine("validado");
                Program.createPyramid(npuntos);
            }
            else
            {
                Console.WriteLine("no validado");
            }           
        }
        static void createPyramid(int num) {
            int asteriscos=1;
            for(int j = 1; j<=num; j++)
            {
                //Espacios en blanco
                for(int blancos = 1; blancos<=num-j; blancos++)
                {
                    Console.Write(" ");
                }
                //Asteriscos
                for(int i=1; i<=asteriscos; i++)
                {
                    Console.WriteLine("* ");
                }
                Console.WriteLine("");
                asteriscos++;
            }
        }
    }
}
