using System;
/*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace cablePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int Value; 
            Console.WriteLine("¿Cuantos productos desea agregar?");
            Value = Convert.ToInt32(Console.ReadLine());
            double[] pPrice = new double[Value];
            double[] bill = new double[Value];
            double[] wbill = new double[Value];
            double[] Metters = new double[Value];
            Boolean[] Checker = new Boolean[Value];
            for(int i = 0; i < Value; i++)
            {
                Console.WriteLine("Escribe el precio del producto {0}", (i + 1));
                pPrice[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < Value; i++)
            {
               Console.WriteLine("Escribe cuantos metros deseas del producto {0}", (i + 1)); 
               Metters[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < Value;i++)
            {
                if(Metters[i] > 20 && Metters[i] < 40)
                {
                    wbill[i] = pPrice[i] * Metters[i]; 
                    bill[i] = pPrice[i] * (Metters[i] * 0.95);
                    Checker[i] = true;
                }
                else if(Metters[i] > 40)
                {
                    wbill[i] = pPrice[i] * Metters[i];
                    bill[i] = pPrice[i] * (Metters[i] * 0.95);
                    Checker[i] = true;
                }
                else
                {
                    bill[i] = pPrice[i] * Metters[i];
                    Checker[i] = false;  
                }
            }
            for(int i = 0; i < Value; i++)
            {
                if(Checker[i] == true)
                {
                    Console.WriteLine("El producto {0} cuesta ${1} y con descuento aplicado queda en ${2}", (i + 1), bill[i], wbill[i]);
                }
                else
                {
                    Console.WriteLine("el producto {0} te vale ${1}", (i + 1), bill[i]);
                }
            }
        }
    }
}
