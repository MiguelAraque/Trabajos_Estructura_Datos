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
            int n1, n2, result, Option;
            String check1, check2;
            bool numberChecker;
            do
            {
                Console.WriteLine("Escriba el numero 1");
                check1 = Console.ReadLine();
                numberChecker = int.TryParse(check1, out n1);
                if(!numberChecker)
                {
                    Console.WriteLine("{0} no es un numero valido, intenta denuevo", check1);
                    Console.WriteLine("");
                }
                else
                {
                    if(n1 < 100)
                    {
                        Console.WriteLine("Lo siento, debe ser un numero mayor a 100");
                    }
                }
            } while (!numberChecker || n1 < 100);
            
            do
            {
                Console.WriteLine("Escriba el numero 2");
                check2 = Console.ReadLine();
                numberChecker = int.TryParse(check2, out n2);
                if(!numberChecker)
                {
                    Console.WriteLine("{0} no es un numero valido, intenta denuevo", check2);
                    Console.WriteLine("");
                }
                else
                {   
                    if(n2 < 100)
                    {
                        Console.WriteLine("Lo siento, debe ser un numero mayor a 100");
                    }
                }   
            }while (!numberChecker || n2 < 100);
            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elije una opción: ");
                Option = Convert.ToInt32(Console.ReadLine());
                
                switch(Option)
                {
                    case 1:
                        result = n1 + n2;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado entre {0} y {1} es {2}",n1, n2, result);           
                    break;
                    case 2:
                        result = n1 - n2;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado entre {0} y {1} es {2}",n1, n2, result);
                    break;
                    case 3:
                        result = n1 * n2;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado entre {0} y {1} es {2}",n1, n2, result);
                    break;
                    case 4:
                        result = n1 / n2;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado entre {0} y {1} es {2}",n1, n2, result);
                    break;
                }
            }while(Option != 5);
        }
    }
}
