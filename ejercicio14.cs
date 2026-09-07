using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace practica4
{
    internal class ejercicio14
    {
        static void Main(string[] args)
        {
            const int UMBRAL_CRITICO = 1500;
            int totalGeneral = 0;

            for (int z = 1; z <= 2; z++)
            {
                int subtotal = 0;

                for (int d = 1; d <= 4; d++)
                {
                    Console.Write("Hectareas afectadas zona " + z + " dia " + d + ": ");
                    subtotal += int.Parse(Console.ReadLine());
                }
                totalGeneral += subtotal;

                if (subtotal > UMBRAL_CRITICO)
                {
                    Console.WriteLine("Zona  " + z + " CRITICO");
                }
                else
                {
                    Console.WriteLine("Zona " + z + " CONTROLADO");
                }
            }
            Console.WriteLine("Total general San Ignacio: " + totalGeneral);
            Console.ReadLine();
        }
    }
}
