using System;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mathStudents = new int[5];
            int[] englishStudents = new int[5];
            int[] spanishStudents = new int[5];
            int[] physicsStudents = new int[5];

            //Pedir notas

                for(int i = 0; i < mathStudents.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Escribe la nota del estudiante {0} en matematicas", (i + 1));
                        mathStudents[i] = int.Parse(Console.ReadLine());
                        if(mathStudents[i] < 0 || mathStudents[i] > 100)
                        {
                            Console.WriteLine("La nota debe ser entre 1 y 100");
                            i--;
                        }
                    }while(mathStudents[i] < 0 || mathStudents[i] > 100);
                    
                }
            

                for(int i = 0; i < englishStudents.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Escribe la nota del estudiante {0} en ingles", (i + 1));
                        englishStudents[i] = int.Parse(Console.ReadLine());
                        if(englishStudents[i] < 0 || englishStudents[i] > 100)
                        {
                            Console.WriteLine("La nota debe ser entre 1 y 100");
                            i--;
                        }
                    }while(englishStudents[i] < 0 || englishStudents[i] > 100);
                    
                }


                for(int i = 0; i < spanishStudents.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Escribe la nota del estudiante {0} en español", (i + 1));
                        spanishStudents[i] = int.Parse(Console.ReadLine());
                        if(spanishStudents[i] < 0 || spanishStudents[i] > 100)
                        {
                            Console.WriteLine("La nota debe ser entre 1 y 100");
                            i--;
                        }
                    }while(spanishStudents[i] < 0 || spanishStudents[i] > 100);
                    
                }

                for(int i = 0; i < physicsStudents.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Escribe la nota del estudiante {0} en fisica", (i + 1));
                        physicsStudents[i] = int.Parse(Console.ReadLine());
                        if(physicsStudents[i] < 0 || physicsStudents[i] > 100)
                        {
                            Console.WriteLine("La nota debe ser entre 1 y 100");
                            i--;
                        }
                    }while(physicsStudents[i] < 0 || physicsStudents[i] > 100);
                    
                }

            //Evaluar notas
            Console.WriteLine("");
            for(int i = 0; i < mathStudents.Length; i++)
            {
                if(mathStudents[i] < 50)
                {
                    Console.WriteLine("La nota del estudiante {0} en matematicas es insuficiente", (i + 1));
                }
                else if(mathStudents[i] >= 50 && mathStudents[i] <= 59)
                {
                    
                    Console.WriteLine("La nota del estudiante {0} en matematicas es suficiente", (i + 1));
                }
                else if(mathStudents[i] >= 60 && mathStudents[i] <= 69)
                {
                    Console.WriteLine("La nota del estudiante {0} en matematicas es buena", (i + 1));
                }
                else if(mathStudents[i] >= 70 && mathStudents[i] <= 89)
                {
                    Console.WriteLine("La nota del estudiante {0} en matematicas es notable", (i + 1));
                }
                else if(mathStudents[i] >= 90 && mathStudents[i] <= 100)
                {
                    Console.WriteLine("La nota del estudiante {0} en matematicas es sobresaliente", (i + 1));
                }
            }
            Console.WriteLine("");
            for(int i = 0; i < englishStudents.Length; i++)
            {
                if(englishStudents[i] < 50)
                {
                    Console.WriteLine("La nota del estudiante {0} en ingles es insuficiente", (i + 1));
                }
                else if(englishStudents[i] >= 50 && englishStudents[i] <= 59)
                {
                    Console.WriteLine("La nota del estudiante {0} en ingles es suficiente", (i + 1));
                }
                else if(englishStudents[i] >= 60 && englishStudents[i] <= 69)
                {
                    Console.WriteLine("La nota del estudiante {0} en ingles es buena", (i + 1));
                }
                else if(englishStudents[i] >= 70 && englishStudents[i] <= 89)
                {
                    Console.WriteLine("La nota del estudiante {0} en ingles es notable", (i + 1));
                }
                else if(englishStudents[i] >= 90 && englishStudents[i] <= 100)
                {
                    Console.WriteLine("La nota del estudiante {0} en ingles es sobresaliente", (i + 1));
                }
            }
            Console.WriteLine("");
            for(int i = 0; i < spanishStudents.Length; i++)
            {
                if(spanishStudents[i] < 50)
                {
                    Console.WriteLine("La nota del estudiante {0} en español es insuficiente", (i + 1));
                }
                else if(spanishStudents[i] >= 50 && spanishStudents[i] <= 59)
                {
                    Console.WriteLine("La nota del estudiante {0} en español es suficiente", (i + 1));
                }
                else if(spanishStudents[i] >= 60 && spanishStudents[i] <= 69)
                {
                    Console.WriteLine("La nota del estudiante {0} en español es buena", (i + 1));
                }
                else if(spanishStudents[i] >= 70 && spanishStudents[i] <= 89)
                {
                    Console.WriteLine("La nota del estudiante {0} en español es notable", (i + 1));
                }
                else if(spanishStudents[i] >= 90 && spanishStudents[i] <= 100)
                {
                    Console.WriteLine("La nota del estudiante {0} en español es sobresaliente", (i + 1));
                }
            }
            Console.WriteLine("");
            for(int i = 0; i < physicsStudents.Length; i++)
            {
                if(physicsStudents[i] < 50)
                {
                    Console.WriteLine("La nota del estudiante {0} en fisica es insuficiente", (i + 1));
                }
                else if(physicsStudents[i] >= 50 && physicsStudents[i] <= 59)
                {
                    Console.WriteLine("La nota del estudiante {0} en fisica es suficiente", (i + 1));
                }
                else if(physicsStudents[i] >= 60 && physicsStudents[i] <= 69)
                {
                    Console.WriteLine("La nota del estudiante {0} en fisica es buena", (i + 1));
                }
                else if(physicsStudents[i] >= 70 && physicsStudents[i] <= 89)
                {
                    Console.WriteLine("La nota del estudiante {0} en fisica es notable", (i + 1));
                }
                else if(physicsStudents[i] >= 90 && physicsStudents[i] <= 100)
                {
                    Console.WriteLine("La nota del estudiante {0} en fisica es sobresaliente", (i + 1));
                }
            }
              
            
        }
    }
}
