using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio15
    {
        static void Main(string[] args)
        {
            const int CODIGO_ACCESO = 2016;
            const int INTENTOS_MAXIMOS = 4;
            int intentos = INTENTOS_MAXIMOS;
            bool acertado = false;

            do
            {
                Console.WriteLine("Ingrese el codigo de acceso: ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == CODIGO_ACCESO)
                {
                    acertado = true;
                    Console.Write("Ingrese nivel de permiso ( 1=consulta, 2=edicion); ");
                    int permiso = int.Parse(Console.ReadLine());

                    if (permiso == 1)
                    {
                        Console.WriteLine("Acceso concedido: Consulta.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso concedido: Edicion.");
                    }
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                    {
                        Console.WriteLine("Codigo incorrecto. Intentos restantes: " + intentos);
                    }
                }
            } while (intentos > 0 && !acertado);

            if (acertado)
            {
                Console.WriteLine("Cuenta bloqueada.");
            }
            Console.ReadLine();
        }
    }
}
