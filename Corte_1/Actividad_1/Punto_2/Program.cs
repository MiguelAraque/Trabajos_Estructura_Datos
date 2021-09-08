using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int s = 9;
            Console.WriteLine("Venta de peliculas");
            Console.WriteLine("Precio: $9");
            Console.WriteLine("Si compra 3 peliculas se cobran 2");
            Console.Write("");
            Console.WriteLine("¿Cuantas peliculas quieres comprar?");
            p = Convert.ToInt32(Console.ReadLine());
            if(p == 3)
            {
                p = (p - 1)*s;
                Console.WriteLine("El costo de las peliculas es ${0} con descuento aplicado", p); 
            }
            else
            {
                p = p * s;
                Console.WriteLine("El costo de las peliculas es ${0}", p);
            }
        }
    }
}
