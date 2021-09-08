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
            Console.WriteLine(Program.AlfabetCounter());
        }
        static String AlfabetCounter()
        {
            string result = "";
            int Number;
            Char[] Alfabet = new Char[27];
            Alfabet[1] = 'A';
            Alfabet[2] = 'B';
            Alfabet[3] = 'C';
            Alfabet[4] = 'D';
            Alfabet[5] = 'E';
            Alfabet[6] = 'F';
            Alfabet[7] = 'G';
            Alfabet[8] = 'H';
            Alfabet[9] = 'I';
            Alfabet[10] = 'J';
            Alfabet[11] = 'K';
            Alfabet[12] = 'L';
            Alfabet[13] = 'M';
            Alfabet[14] = 'N';
            Alfabet[15] = 'O';
            Alfabet[16] = 'P';
            Alfabet[17] = 'Q';
            Alfabet[18] = 'R';
            Alfabet[19] = 'S';
            Alfabet[20] = 'T';
            Alfabet[21] = 'U';
            Alfabet[22] = 'V';
            Alfabet[23] = 'W';
            Alfabet[24] = 'X';
            Alfabet[25] = 'Y';
            Alfabet[26] = 'Z';
            do
            {
                Console.WriteLine("Escribe un numero");
                Number = Convert.ToInt32(Console.ReadLine());
                if(Number >= 1 && Number <= 26)
                {
                    for(int i = 1; i < Alfabet.Length; i++)
                    {
                        if(i == Number)
                        {
                            result += Alfabet[i];
                        }
                    }
                }
                else if(Number == -1)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Numero no valido, escribe otro");
                }
            }while(Number != -1);
            return result;
        }
    }
}
