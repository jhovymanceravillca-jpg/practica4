using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio18
    {
        static void Main(string[] args)
        {
            int totalCentros = 0;
            int hitosConmemorados = 0;

            for (int i = 0; i < 8; i++)
            {
                int anio = 2018 + i;
                Console.Write("Centros registrados en " + anio + ": ");
                int centros = int.Parse(Console.ReadLine());
                totalCentros += centros;

                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("Ano de hito.");
                    Console.Write("Hubo acto conmemorativo? 1) Si 2) No: ");
                    int acto = int.Parse(Console.ReadLine());

                    if (acto == 1)
                    {
                        Console.WriteLine("Conmemoracion registrada.");
                        hitosConmemorados++;
                    }
                    else
                    {
                        Console.WriteLine("Sin conmemoracion.");
                    }
                }
            }
            Console.WriteLine("Total centros: " + totalCentros);
            Console.WriteLine("Hitos conmemorados " + hitosConmemorados);
            Console.ReadLine();
        }
    }
}
