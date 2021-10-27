using System;

namespace ActividadVIII
{
    class ObjectExersices
    {
        public static void Menu()
        {
            Console.Write("Escribe un nombre: ");
            String personName = Convert.ToString(System.Console.ReadLine());
            Console.Write("Escribe la edad: ");
            int personAge = int.Parse(System.Console.ReadLine());
            Person PersonINFO = new Person(personName, personAge);
            String f = PersonINFO.ToString();
            Console.WriteLine("La informacion extraida fue: " + f);
        }
    }
}