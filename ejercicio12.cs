using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio12
    {
        static void Main(string[] args)
        {
            const int UMBRAL_ALTO = 240;
            const int UMBRAL_MEDIO = 100;
            int confirmados = 0;
            int pendientes = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Articulos analizados en estudio " + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= UMBRAL_ALTO)
                {
                    Console.WriteLine("Verificado en campo? 1) Si 2) No: ");
                    int verificado = int.Parse(Console.ReadLine());

                    if (verificado == 1)
                    {
                        Console.WriteLine("ANALISIS ALTO CONFIRMADO");
                        confirmados++;
                    }
                    else
                    {
                        Console.WriteLine("ANALISIS ALTO PENDIENTE DE VERIFICACION");
                        pendientes++;
                    }
                }
                else if (valor >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("ANALISIS MEDIO");
                }
                else
                {
                    Console.WriteLine("ANALISIS BAJO");
                }
            }
            Console.WriteLine("Confirmados: " + confirmados + " Pendientes: " + pendientes);
            Console.ReadLine();
        }
    }
}
