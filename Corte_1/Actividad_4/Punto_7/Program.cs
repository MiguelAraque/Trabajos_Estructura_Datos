using System;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] studentNames = new String[12];
            double[] studentNotes = new double[studentNames.Length];
            String[] Result = new String[studentNames.Length];
            Program.requestStudentNames(studentNames);
            Program.requestStudentNotes(studentNotes, studentNames);
            Program.ShowResults(studentNames, Result, studentNotes);
        }
        static void requestStudentNames(String[] studentNames)
        {
            for(int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("Escribe el nombre del estudiante {0}",(i + 1));
                studentNames[i] = Convert.ToString(Console.ReadLine());
            }
            
        }
        static void requestStudentNotes(double[] studentNotes, String[] studentNames)
        {
            for(int i = 0; i < studentNotes.Length; i++)
            {
                do
                {
                    Console.WriteLine("Escribe la nota del estudiante {0}",(i + 1));
                    studentNotes[i] = Convert.ToDouble(Console.ReadLine());
                }while(studentNotes[i] <= 0 && studentNotes[i] >= 10);
            }
        }
        static void ShowResults(String[] studentNames, String[] Result, double[] studentNotes)
        {
            for(int i = 0; i < studentNames.Length; i++)
            {
                if(studentNotes[i] >= 0 && studentNotes[i] <= 4.99)
                {
                    Result[i] = "insuficiente";
                    Console.WriteLine("El estudiante {0} obtuvo una calificacion de {1}, es {2}", studentNames[i], studentNotes[i], Result[i]);
                }
                else if(studentNotes[i] >= 5 && studentNotes[i] <= 6.99)
                {
                    Result[i] = "aceptable";
                    Console.WriteLine("El estudiante {0} obtuvo una calificacion de {1}, es {2}", studentNames[i], studentNotes[i], Result[i]);
                }
                else if(studentNotes[i] >= 7 && studentNotes[i] <= 8.99)
                {
                    Result[i] = "sobresaliente";
                    Console.WriteLine("El estudiante {0} obtuvo una calificacion de {1}, es {2}", studentNames[i], studentNotes[i], Result[i]);
                }
                else if(studentNotes[i] >= 9 && studentNotes[i] <= 10)
                {
                    Result[i] = "excelente";
                    Console.WriteLine("El estudiante {0} obtuvo una calificacion de {1}, es {2}", studentNames[i], studentNotes[i], Result[i]);
                }

                
            }
        }
    }
}
