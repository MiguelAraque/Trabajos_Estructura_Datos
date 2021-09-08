using System;

namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double DogAge, FirstDogAge= 10.6, After2YearsAge = 4, DogAgeinHumanYears = 0;
            Console.WriteLine("Saber cuantos años tiene tu perro en años humanos");
            Console.WriteLine("");
            Console.WriteLine("Escribe la edad de tu perro");
            DogAge = Convert.ToInt32(Console.ReadLine());
            if(DogAge <= 2 && DogAge > 0)
            {
                DogAge = DogAge * FirstDogAge;
            }
            else
            {
                DogAgeinHumanYears = DogAge-(DogAge-2);
                DogAgeinHumanYears = DogAgeinHumanYears * FirstDogAge;
                DogAge = (DogAge-2) * After2YearsAge;
                DogAge = DogAge + DogAgeinHumanYears;
            }
            Console.WriteLine("Tu perro tiene {0} años humanos", DogAge);

        }
    }
}
