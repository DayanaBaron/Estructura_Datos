using System;

using System.Linq;

using System.Collections;

using System.Collections.Generic;

namespace Ejercicio10

{

    class Contraseña

    {
        static void Main(string[] args)

        {
            string contrasena;

            Console.WriteLine("Digite la contraseña");

            contrasena = (System.Console.ReadLine());


            while (contrasena != "iloveyou123")

            {
                if (contrasena != "iloveyou123")
                {
                    Console.WriteLine("Contraseña incorrecta");
                    Console.WriteLine("Escribir contraseña de nuevo");
                    contrasena = (System.Console.ReadLine());
                }

                if (contrasena == "iloveyou123")
                    Console.WriteLine("Contraseña correcta");

            }
        }
    }
}