using System;
using System.Collections;

namespace ArrayListEjemplo
{
    class EjercciosArrayList
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList();
            chooseOption(shoppingList);
        }
        static void chooseOption(ArrayList shoppingList)
        {
            int option;
            do
            {
                Console.WriteLine("Lista de la compra");
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Limpiar lista");
                Console.WriteLine("4. Salir");
                Console.Write("Elije una opción: ");
                option = int.Parse(System.Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.Write("Escribe el item: ");
                        shoppingList.Add(System.Console.ReadLine());
                    break;
                    case 2:
                        foreach (var item in shoppingList)
                        {
                            Console.WriteLine(item);
                        }
                    break;
                    case 3:
                        shoppingList.Clear();
                    break;
                    case 4:
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Elije una opcion valida");
                    break;
                }
            }while(option != 4);
        }
    }
}
