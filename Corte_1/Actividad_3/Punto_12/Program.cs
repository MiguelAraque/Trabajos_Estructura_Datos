using System;

namespace electionCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CandidateCount = new int[3];
            CandidateCount[0] = 0;
            CandidateCount[1] = 0; 
            CandidateCount[2] = 0;
            int option = 4, votecount = 0;
            do
            {
                Console.WriteLine("Por quien vas a votar");
                Console.WriteLine("Candidato 1");
                Console.WriteLine("Candidato 2");
                Console.WriteLine("Candidato 3");
                Console.Write("Elije una opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 0:
                        if(votecount < 20)
                        {
                            Console.WriteLine("El minimo de votos debe ser 20");
                            option++;
                        }
                        else
                        {
                            Program.WinnerAnalyzer(CandidateCount[0], CandidateCount[1], CandidateCount[2]);
                        }
                    break;
                    case 1:
                        CandidateCount[0]++;
                        votecount++;
                    break;
                    case 2:
                        CandidateCount[1]++;
                        votecount++;
                    break;
                    case 3:
                        CandidateCount[2]++;
                        votecount++;
                    break;
                    default:
                        Console.WriteLine("Elige una opcion valida");
                    break;
                }
            }while(option != 0);
        }
        static void WinnerAnalyzer(int Candidate1, int Candidate2, int Candidate3)
        {
            if(Candidate1 > Candidate2 && Candidate1 > Candidate3)
            {
                Console.WriteLine("El ganador es el candidato 1 con {0} votos", Candidate1);
            }
            else if(Candidate2 > Candidate1 && Candidate2 > Candidate3)
            {
                Console.WriteLine("El ganador es el candidato 2 con {0} votos", Candidate2);
            }
            else if(Candidate3 > Candidate1 && Candidate3 > Candidate2)
            {
                Console.WriteLine("El ganador es el candidato 3 con {0} votos", Candidate3);
            }
            else
            {
                Console.WriteLine("No se puede saber quien es el ganador");
            }
        }
    }
}
