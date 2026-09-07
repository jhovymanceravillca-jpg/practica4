using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio19
    {
        static void Main(string[] args)
        {
            const int RECURSOS_INICIALES = 3;
            const int META_PUNTOS = 200;
            const int PUNTOS_INTENSIVA = 12;
            int recursos = RECURSOS_INICIALES;
            int puntos = 0;
            bool retirado = false;

            do
            {
                Console.WriteLine("1) Intensiva 2) Preventiva 3) Retirarse");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    puntos += PUNTOS_INTENSIVA;
                    recursos--;
                    if (recursos == 1)
                    {
                        Console.WriteLine("Queda 1 solo recurso.");
                    }
                }
                else if (opcion == 2)
                {
                    puntos += PUNTOS_INTENSIVA / 2;
                }
                else if (opcion == 3)
                {
                    retirado = true;
                }
            } while (recursos > 0 && !retirado && puntos < META_PUNTOS);

            if (puntos >= META_PUNTOS)
            {
                Console.WriteLine("ZONA ACCESIBLE");
            }
            else if (puntos >= 100)
            {
                Console.WriteLine("ZONA NO ACCESIBLE");
            }
            Console.ReadLine();
        }
    }
}
