using System;
    /*  Creado por: Miguel Andres Araque Moreno
    *   Grupo: 239-2A
    *   Turno: Diurno
    */
namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String actDay = DateTime.Now.ToString("dd");
            String actMonth = DateTime.Now.ToString("MM");
            String actYear = DateTime.Now.ToString("yyyy");
            int nDay = Convert.ToInt32(actDay);
            int nMonth = Convert.ToInt32(actMonth);
            int nYear = Convert.ToInt32(actYear);
            
            int day, month, year;
            
            Console.WriteLine("Escribe la fecha que quieras");
            do
            {
                Console.WriteLine("dia: ");
                day = Convert.ToInt32(Console.ReadLine());
                if(day <= 0 || day > 31)
                {
                    Console.WriteLine("Debe ser un dia valido");
                }

            }while(day <= 0 || day > 31);
            do
            {
            Console.WriteLine("mes: ");
            month = Convert.ToInt32(Console.ReadLine());
            if(month <= 0 || month > 12)
            {
                Console.WriteLine("Debe ser un mes valido");
            }    
            } while (month <= 0 || month > 12);
            do
            {
                Console.WriteLine("año: ");
                year = Convert.ToInt32(Console.ReadLine());
                if(year > nYear)
                {
                    Console.WriteLine("El año debe ser menor");
                }
            } while (year > nYear);
            
            nDay = nDay - day;
            nMonth = nMonth - month;
            nYear = nYear - year;

            if(nDay < 0)
            {
                nDay = nDay * -1;
            }
            if(nMonth < 0)
            {
                nMonth = nMonth * -1;
            }
            Console.WriteLine("Han pasado " + nDay + " dias, " + nMonth + " meses y " + nYear + " años");
        }
    }
}
