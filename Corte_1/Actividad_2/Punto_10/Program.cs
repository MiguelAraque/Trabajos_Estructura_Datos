using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, Result, groundPrice = 2100, finalPrice, n;
            Console.WriteLine("¿Cual es el largo del terreno?");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cual es el ancho del terreno¨?");
            height = Convert.ToDouble(Console.ReadLine());
            Result = weight * height;
            Console.WriteLine("El terreno tiene {0} metros cuadrados", Result);
            n = Result * groundPrice;
            if(Result > 400 && Result < 500)
            {
                Result = 90 * Result;
                Result = Result / 100;
                finalPrice = groundPrice * Result;
                Console.WriteLine("El precio del terreno es ${0}, tiene un descuento del 10% y el total es ${1}", n, finalPrice);
            }
            else if(Result > 500 && Result < 1000)
            {
                Result = 83 * Result;
                Result = Result / 100;
                finalPrice = groundPrice * Result;
                Console.WriteLine("El precio del terreno es ${0}, tiene un descuento del 17% y el total es ${1}", n, finalPrice);
            }
            else if(Result > 1000)
            {
                Result = 90 * Result;
                Result = Result / 100;
                finalPrice = groundPrice * Result;
                Console.WriteLine("El precio del terreno es ${0}, tiene un descuento del 25% y el total es ${1}", n, finalPrice);
            }
            else
            {
                Console.WriteLine("El precio del terreno es ${0}", n);
            }
        }
    }
}
