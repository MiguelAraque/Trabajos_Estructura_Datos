using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace servicePrices
{
    class Program
    {
        static void Main(string[] args)
        {
            double water, light, gas;
            int stratum;
            Console.WriteLine("Ingresa el precio del agua!");
            water = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el precio de la luz");
            light = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el precio del gas");
            gas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿De que estrato eres?");
            stratum = Convert.ToInt32(Console.ReadLine());
            if(stratum == 1)
            {
                water = water * 0.80;
                light = light * 0.80;
                gas = gas * 0.80;
                Console.WriteLine("Como usted es estrato 1 se le dara un descuento del 20%, debe pagar:");
                Console.WriteLine("Agua: ${0}", water);
                Console.WriteLine("Luz: ${0}", light);
                Console.WriteLine("Gas: ${0}", gas);
            }
            else if(stratum == 2)
            {
                water = water * 0.85;
                light = light * 0.85;
                gas = gas * 0.85;
                Console.WriteLine("Como usted es estrato 2 se le dara un descuento del 15%, debe pagar:");
                Console.WriteLine("Agua: ${0}", water);
                Console.WriteLine("Luz: ${0}", light);
                Console.WriteLine("Gas: ${0}", gas);                
            }
            else if(stratum >= 3)
            {
                water = water * 0.91;
                light = light * 0.91;
                gas = gas * 0.91;
                Console.WriteLine("Como usted es estrato {0} se le dara un descuento del 9%, debe pagar:", stratum);
                Console.WriteLine("Agua: ${0}", water);
                Console.WriteLine("Luz: ${0}", light);
                Console.WriteLine("Gas: ${0}", gas);
            }
            else
            {
                Console.WriteLine("El estrato no es valido, intente de nuevo");
            }
        }
    }
}
