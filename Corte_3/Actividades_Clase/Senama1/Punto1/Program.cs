//Modificar el ejercicios número 3 para que trabaje con un "case"
//Desarrolle un programa que permita operar al menos 7 métodos diferentes de las colas

using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        // Esta  es   la  funcion principal del   programa
        // Aqui inicia  la aplicacion static void   Main(string[] args)
        static void Main(string[] args)
        {
            int Opcion = 0;
            int Valor = 0;
            bool encontrado = false;

            // Creamos el Queue
            Queue miCola = new Queue();

            do
            {
                // Menú para manipular la Cola

                Console.WriteLine("1- Enqueue");     // Agregar un elemento a la cola
                Console.WriteLine("2- Dequeue");     // Borrar un elemento de la cola
                Console.WriteLine("3- Clear");       // Limpiar toda a cola
                Console.WriteLine("4- Contains");    // Ubicar un elemento en la cola
                Console.WriteLine("5- Peek");        // Extraer el primer elemento de la cola
                Console.WriteLine("6- Clone");       // Hace una copia exacta de la cola
                Console.WriteLine("7- Peek");
                Console.WriteLine("8- Salir");

                Console.Write("Dime una opcion del menú: ");
                Opcion = int.Parse(System.Console.ReadLine());
                switch(Opcion)
                {
                    case 1:                    
                        // Agregar un valor al Queue
                        Console.WriteLine("");
                        Console.Write("Introduce un número para la cola:  ");
                        Valor = int.Parse(System.Console.ReadLine());

                        // Adicionamos  el  valor en  el queue
                        miCola.Enqueue(Valor);
                    break;
                    case 2:
                        // Mostrar y extraer un elemento del Queue
                        Valor = (int)miCola.Dequeue();
                        // Mostramos el  elemento
                        Console.WriteLine("");
                        Console.WriteLine("El valor obtenido es: {0}", Valor);
                    break;
                    case 3:
                        // Limpiamos todos los contenidos del Queue
                        miCola.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("La cola ha sido limpiada");
                    break;
                    case 4:
                        // Pedimos  el  valor a  encontrar
                        Console.WriteLine("");
                        Console.Write("Dame el valor a encontrar:  ");
                        Valor = int.Parse(System.Console.ReadLine());

                        // Vemos si el elemento se encuentra
                        encontrado = miCola.Contains(Valor);

                        // Mostramos el  resultado
                        Console.WriteLine("");
                        Console.WriteLine("Encontrado = {0}", encontrado);
                    break;
                    case 5:
                        Console.WriteLine(miCola.Peek());
                    break;
                    case 6:

                    break;
                    case 7:
                        
                                            
                    break;              
                    case 8:
                        Environment.Exit(0);
                    break;

                }
                // Mostramos la  informacion del   stack
                Console.WriteLine("");
                Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                Console.WriteLine("");
            } while (Opcion != 5);

            foreach (int n in miCola)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("___________________");
            Console.WriteLine("");
        }
    }
}
