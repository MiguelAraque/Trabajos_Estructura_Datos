using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = 0, side2 = 0, side3 = 0;
            do
            {
                Console.WriteLine("Escribe el primer lado");
                side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe el segundo lado");
                side2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe el tercer lado"); 
                side3 = Convert.ToInt32(Console.ReadLine()); 
            }while((side1 + side2) < side3);
            Program.Scanner(side1,side2,side3);
        }
        static void Scanner(int side1, int side2, int side3)
        {
            if(side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if(side1 == side2 || side2 == side3)
            {
                Console.WriteLine("Es un triangulo isósceles");
            }
            else if(side1 != side2 && side2 != side3)
            {
                Console.WriteLine("Es un triangulo escaleno");
            }
            if(side3 > side1)
            {
                Console.WriteLine("Es un triangulo acutangulo");
            }
            else if(side3 > side2 && side3 > side1)
            {
                Console.WriteLine("Es un triangulo rectangulo");
            }
            else if(side1 < side3)
            {
                Console.WriteLine("Es un triangulo obtusangulo");
            }
            else
            {
                Console.WriteLine("no se puede calcular");
            }
        }
    }
}
