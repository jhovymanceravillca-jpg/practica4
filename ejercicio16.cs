using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio16
    {
        static void Main(string[] args)
        {
            const int UMBRAL_ALTO = 400;
            const int UMBRAL_MEDIO = 150;
            const double PORCENTAJE_ALTO = 0.20;
            const double PORCENTAJE_MEDIO = 0.10;
            double incentivoTotal = 0;
            int observaciones = 0;

            for (int i = 1; i <= 9; i++)
            {
                Console.Write("Hectareas en parcela " + i + ": ");
                int hectareas = int.Parse(Console.ReadLine());
                double incentivo = 0;

                if (hectareas >= UMBRAL_ALTO)
                {
                    incentivo = hectareas * PORCENTAJE_ALTO;
                }
                else if (hectareas >= UMBRAL_MEDIO)
                {
                    incentivo = hectareas * PORCENTAJE_MEDIO;
                }
                else
                {
                    observaciones++;
                }

                incentivoTotal += incentivo;
                Console.WriteLine("Incentivo: " + incentivo);
            }
            Console.WriteLine("Incentivo total: " + incentivoTotal);
            Console.WriteLine("Observaciones: " + observaciones);
            Console.ReadLine();
        }
    }
}
