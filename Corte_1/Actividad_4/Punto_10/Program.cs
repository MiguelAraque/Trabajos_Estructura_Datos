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
            
            Random RandomNumber = new Random();
            string[,] Lista = new string[5,5];
            
            Lista[0,1] = "Ingles";
            Lista[0,2] = "Francës";
            Lista[0,3] = "Aleman";
            Lista[0,4] = "Ruso";

            Lista[1,0] = "Basico";
            Lista[2,0] = "medio";
            Lista[3,0] = "Perfecto";

            Lista[1,1] = "100";
            Lista[1,2] = "200";
            Lista[1,3] = "1000";
            Lista[1,4] = "350";

            Lista[2,1] = "650";
            Lista[2,2] = "120";
            Lista[2,3] = "50";
            Lista[2,4] = "60";

            Lista[3,1] = "120";
            Lista[3,2] = "100";
            Lista[3,3] = "20";
            Lista[3,4] = "10";

            Lista[4,1] = "50";
            Lista[4,2] = "65";
            Lista[4,3] = "90";
            Lista[4,4] = "30";

            Console.Write("\t\t" + Lista[0,1] + "\t" + Lista[0,2] + "\t" + Lista[0,3] + "\t" + Lista[0,4]+ "\n");
            Console.Write(Lista[1,0] + "\t\t" + Lista[1,1] + "\t" +Lista[1,2] +"\t" + Lista[1,3] + "\t" + Lista[1,4] + "\n");
            Console.Write(Lista[2,0] + "\t\t" + Lista[2,1] + "\t" +Lista[2,2] +"\t" + Lista[2,3] + "\t" + Lista[2,4] + "\n");
            Console.Write(Lista[3,0] + "\t" + Lista[3,1] + "\t" +Lista[3,2] +"\t" + Lista[3,3] + "\t" + Lista[3,4] + "\n");
            
            
        }
    }
}
