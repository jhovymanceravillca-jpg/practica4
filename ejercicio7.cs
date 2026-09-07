using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio7
    {
        static void Main(string[] args)
        {
            const int UMBRAL_ALTO = 400;
            const int UMBRAL_MEDIO = 150;
            int alta = 0;
            int media = 0;
            int baja = 0;

            for (int i = 1; i <= 9; i++)
            {
                Console.Write("Descargas del conjunto " + i + ": ");
                int descargas = int.Parse(Console.ReadLine());

                if (descargas >= UMBRAL_ALTO)
                {
                    Console.WriteLine("DEMANDA ALTA");
                    alta++;
                }
                else if (descargas >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("DEMANDA MEDIA");
                    media++;
                }
                else
                {
                    Console.WriteLine("DEMANDA BAJA");
                    baja++;
                }
            }
            Console.WriteLine("Altas: " + alta + " Medias: " + media + " Bajas: " + baja);
            Console.ReadLine();
        }
    }
}
