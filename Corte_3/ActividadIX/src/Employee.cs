using System;

namespace ActividadIX
{
    class Employee
    {
        public String Name;
        public int Salary;
        
        public Employee(string employeeName, int employeeSalary)
        {
            Name = employeeName;
            Salary = employeeSalary;
        }
        public void showEmployeeInfo()
        {
            Console.Clear();
            Console.WriteLine($"Nombre empleado: {Name}");
            Console.WriteLine($"Salario empleado: {Salary}");
        }
        public void checkTaxes()
        {
            if(Salary > 3000)
            {
                Console.WriteLine("Usted SI debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("Usted NO debe pagar impuestos");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            MainMenu.Main();
        }
    }
}