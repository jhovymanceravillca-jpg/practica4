using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio5
    {
        static void Main(string[] args)
        {
            const int UMBRAL_SEGUNDOS = 90;
            int cumplen = 0;
            int noCumplen = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Segundos de espera promedio cruce " + i + ": ");
                int segundos = int.Parse(Console.ReadLine());

                if (segundos >= UMBRAL_SEGUNDOS)
                {
                    Console.WriteLine("CUMPLE");
                    cumplen++;
                }
                else
                {
                    Console.WriteLine("NO CUMPLE");
                    noCumplen++;
                }
            }
            Console.WriteLine("Cumplen: " + cumplen + " | No cumplen: " + noCumplen);
            Console.ReadLine();
        }
    }
}
