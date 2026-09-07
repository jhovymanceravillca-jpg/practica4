using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio10
    {
        static void Main(string[] args)
        {
            const int UMBRAL_ACEPTABLE = 120;
            int registros = 1;
            double suma = 0;

            while (registros <=9)
            {
                Console.Write("Registros digitalizados " + registros + ": ");
                suma += int.Parse(Console.ReadLine());
                registros++;
            }

            double promedio = suma / 9;
            Console.WriteLine("Promedio: " + promedio);

            if (promedio >= UMBRAL_ACEPTABLE)
            {
                Console.WriteLine("Situacion de La Paz aceptable.");
            }
            else
            {
                Console.WriteLine("Requiere intervencion.");
            }
            Console.ReadLine();
        }
    }
}
