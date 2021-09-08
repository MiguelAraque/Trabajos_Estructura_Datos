using System;

namespace Punto_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String login, pass, loginAuth = "user", passAuth="iloveyou123";
            Console.WriteLine("Inicio de sesión");

            Console.WriteLine("Usuario: (default=user)");
            login = Console.ReadLine();

            if(login == loginAuth)
            {
                Console.WriteLine("Usuario Correcto");
            }
            else
            {
                Console.WriteLine("Usuario incorrecto, vuelve a intentarlo");
            }

            Console.Write("Contraseña: ");
            pass = Console.ReadLine();
            if(pass == passAuth)
            {
                Console.WriteLine("Contraseña correcta, bienvenido");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta, intenta de nuevo");
            }
        }
    }
}
