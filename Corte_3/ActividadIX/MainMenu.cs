using System;
using System.Threading;

namespace ActividadIX
{
    class MainMenu
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Ejercicios de constructores");
                Thread.Sleep(2000);
                Console.WriteLine("1. Empleado");
                Console.WriteLine("2. Operaciones");
                Console.WriteLine("3. Club y Socio");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                switch (int.Parse(System.Console.ReadLine()))
                {
                    case 1:
                        
                        Console.Write("Escribe el nombre del empleado: ");
                        String employeeName = Convert.ToString(System.Console.ReadLine());
                        Console.Write($"Escribe el salario del empleado {employeeName}: ");
                        int employeeSalary = int.Parse(System.Console.ReadLine());
                        Employee employee = new Employee(employeeName,employeeSalary);
                        employee.showEmployeeInfo();
                        employee.checkTaxes();                    
                    break;
                    case 2:
                        int N1;
                        int N2;
                        Console.Write("Escribe el primer numero: ");
                        N1 = int.Parse(System.Console.ReadLine());
                        Console.Write("Escribe el segundo numero: ");
                        N2 = int.Parse(System.Console.ReadLine());
                        Operations Calculator = new Operations(N1, N2);
                        Calculator.Calculator();
                    break;
                    case 3:
                        Club club1 = new Club();
                        club1.MayorAntiguedad();
                        Console.ReadKey();
                    break;
                    default:

                    break;
                }              
            }
            catch (System.FormatException)
            {
                
            }
               
        }
    }
}
