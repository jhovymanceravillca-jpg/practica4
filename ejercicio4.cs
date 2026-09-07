using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            const string OPCION1 = "Ver el registro de sensores de suelo";
            const string OPCION2 = "Ver la meta del periodo";
            const string OPCION3 = "Ver el rango valido de porcentaje de humedad del suelo";
            int opcion;

            do
            {
                Console.WriteLine("1) " + OPCION1);
                Console.WriteLine("2) " + OPCION2);
                Console.WriteLine("3) " + OPCION3);
                Console.WriteLine("4) Salir");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine(OPCION1);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine(OPCION2);
                }
                else if (opcion == 3)
                {
                    Console.WriteLine(OPCION3);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del sistema.");
                }
                else
                {
                    Console.WriteLine("Opcion no existe.");
                }
            } while (opcion != 4);
            Console.ReadLine();
        }
    }
}
