using System;

namespace Punto7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] ServicesPrices = new double[3,3];
            string[] servicesNames = new string[3];
            servicesNames[0] = "el agua";
            servicesNames[1] = "la luz";
            servicesNames[2] = "el gas";
            requestServicesPrice(ServicesPrices, servicesNames);
            showResult(ServicesPrices, servicesNames);
        }
        static void requestServicesPrice(double[,] ServicePrice, string[] services)
        {
            int Stratum;
            double discount;
            for(int y = 0 ; y < ServicePrice.GetLength(1); y++)
            {
                Console.WriteLine("Escribe el estrato de la familia {0}", y + 1);
                Stratum = int.Parse(System.Console.ReadLine());
                for(int x = 0 ; x < ServicePrice.GetLength(0); x++)
                {
                    try
                    {
                        Console.WriteLine("Escribe el precio a pagar de {0}", services[x]);
                        ServicePrice[x,y] = int.Parse(System.Console.ReadLine()); 
                        switch(Stratum)
                        {
                            case 1:
                                discount = 0.80;
                                ServicePrice[x,y] -= discount;
                            break;
                            case 2:
                                discount = 0.85;
                                ServicePrice[x,y] -= discount;
                            break;
                            case >= 3:
                                discount = 0.91;
                                ServicePrice[x,y] *= discount;
                            break;
                        }
                    }
                    catch(System.FormatException)
                    {
                        Console.WriteLine("El valor ingresado debe ser un numero");
                        y--;
                    }
                }
            }
        }
        static void showResult(double[,] servicesPrice, string[] servicesNames)
        {
            Console.Write("\t 1 \t 2 \t 3 \n");
            Console.Write("Agua: \t {0} \t {1} \t {2} \n", servicesPrice[0,0], servicesPrice[0,1], servicesPrice[0,2]);
            Console.Write("Luz: \t {0} \t {1} \t {2} \n", servicesPrice[1,0], servicesPrice[1,1], servicesPrice[1,2]);
            Console.Write("Gas: \t {0} \t {1} \t {2} \n", servicesPrice[2,0], servicesPrice[2,1], servicesPrice[2,2]);
        }
    }
}
