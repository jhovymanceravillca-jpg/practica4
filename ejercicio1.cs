using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            const int TOTAL_RUTAS = 9;
            int contador = 1;

            while (contador <= TOTAL_RUTAS)
            {
                Console.WriteLine("Ruta registrada: " + contador);
                contador++;
            }

            Console.WriteLine("Total procesado: " + TOTAL_RUTAS);
            Console.ReadLine();
        }
    }
}
