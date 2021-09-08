using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
            Console.WriteLine("Escribe el numero (1 - 12)");
            number = Convert.ToInt32(Console.ReadLine());
            if(number < 0 || number > 12)
            {
                Console.WriteLine("Escribe un numero valido");
                Console.WriteLine("");
            }
            }while(number < 0 || number > 12);
            switch(number)
            {
                case 1:
                    Console.WriteLine("{0} es enero y tiene 31 dias", number);
                break;
                case 2:
                    Console.WriteLine("{0} es febrero y tiene 28 dias", number);
                break;
                case 3:
                    Console.WriteLine("{0} es marzo y tiene 31 dias", number);
                break;
                case 4:
                    Console.WriteLine("{0} es abril y tiene 30 dias", number);
                break;
                case 5:
                    Console.WriteLine("{0} es mayo y tiene 31 dias", number);
                break;
                case 6:
                    Console.WriteLine("{0} es junio y tiene 30 dias", number);
                break;
                case 7:
                    Console.WriteLine("{0} es julio y tiene 31 dias", number);
                break;
                case 8:
                    Console.WriteLine("{0} es agosto y tiene 31 dias", number);
                break;
                case 9:
                    Console.WriteLine("{0} es septiembre y tiene 30 dias", number);
                break;
                case 10:
                    Console.WriteLine("{0} es octubre y tiene 31 dias", number);
                break;
                case 11:
                    Console.WriteLine("{0} es noviembre y tiene 30 dias", number);
                break;
                case 12:
                    Console.WriteLine("{0} es diciembre y tiene 31 dias", number);
                break;
            }
        }
    }
}
