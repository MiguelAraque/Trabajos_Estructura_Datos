using System;

namespace ActividadIX
{
    class Socio
    {
        private string Name;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write($"Ingrese la antiguedad de {Name}:");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public void printSocioInfo() 
        {
            Console.WriteLine($"{Name} tiene una antiguedad de {antiguedad}");
        }

        public int getAntiguedad()
        {
            return antiguedad;
        }
    }


    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club() 
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorAntiguedad()
        {
            Console.Write("Socio con mayor antiguedad: ");
            if (socio1.getAntiguedad() > socio2.getAntiguedad() &&
                socio1.getAntiguedad() > socio3.getAntiguedad())
            {
                socio1.printSocioInfo();
            }
            else 
            {
                if (socio2.getAntiguedad() > socio3.getAntiguedad())
                {
                    socio2.printSocioInfo();
                }
                else
                {
                    socio3.printSocioInfo();
                }
            }
        }
    }
}