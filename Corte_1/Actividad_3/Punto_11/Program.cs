using System;

namespace payScanner
{
    class Program
    {
        static void Main(string[] args)
        {            
            int salary, gender, CountF = 0, CountM = 0, FTotal = 0, MTotal = 0;
            do
            {
                Console.WriteLine("Escribe el salario del empleado");
                salary = Convert.ToInt32(Console.ReadLine());
                if(salary != 0)
                {
                    Console.WriteLine("Escribe el genero del empleado(1 = Mujer, 2 = Hombre)");
                    gender = Convert.ToInt32(Console.ReadLine());
                    if(gender == 1)
                    {
                        FTotal = FTotal + salary;
                        if(salary > 1000000)
                        {
                        CountF = CountF + 1;
                        }
                    }              
                    else if(gender == 2)
                    {
                        MTotal = MTotal + salary;
                        if(salary < 900000)
                        {
                            CountM = CountM + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Escribe un valor valido");
                    }
                }
            }while(salary != 0);
            Console.WriteLine("Hay {0} mujeres que ganan mas de $1000000",CountF);
            Console.WriteLine("Hay {0} Hombres que ganan menos de $900000", CountM);
            Console.WriteLine("Las mujeres tienen ${0} pesos", FTotal);
            Console.WriteLine("Los hombres tienen ${0} pesos", MTotal);

        }
    }
}
