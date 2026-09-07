using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio17
    {
        static void Main(string[] args)
        {
            const int CENTINELA = -1;
            const int UMBRAL_ALTO = 2500;
            const int UMBRAL_MEDIO = 1200;
            int panaderias = 0;
            int suma = 0;
            int valor = 0;

            Console.Write("Unidades de pan (-1 para terminar): ");
            valor = int.Parse(Console.ReadLine());

            while (valor != CENTINELA)
            {
                panaderias++;
                suma += valor;
                Console.Write("Unidades de pan (-1 para terminar): ");
                valor = int.Parse(Console.ReadLine());
            }
            if (panaderias > 0)
            {
                double promedio = (double)suma / panaderias;
                Console.WriteLine("Promedio: " + promedio);

                if (promedio >= UMBRAL_ALTO)
                {
                    Console.WriteLine("Produccion Alta.");
                }
                else if (promedio >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("Produccion Media.");
                }
                else
                {
                    Console.WriteLine("Produccion Baja.");
                }
            }
            else
            {
                Console.WriteLine("No hubo datos.");
            }
            Console.ReadLine();
        }
    }
}
