using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace practica4
{
    internal class ejercicio13
    {
        static void Main(string[] args)
        {
            const int META_DOLARES = 20000;
            int acumulado = 0;
            int periodos = 0;

            while (acumulado < META_DOLARES)
            {
                Console.WriteLine("Ingrese avance del periodo: ");
                int avance = int.Parse(Console.ReadLine());

                if (avance == 0)
                {
                    Console.WriteLine("Periodo improductivo");
                }
                else
                {
                    acumulado += avance;
                }
                periodos++;

                int pendiente = META_DOLARES - acumulado;
                if (pendiente > 0)
                {
                    Console.WriteLine("Saldo pendiente: " + pendiente);
                }
            }
            int excedente = acumulado - META_DOLARES;
            Console.WriteLine("Total acumulado: " + acumulado);
            Console.WriteLine("Excedente: " + excedente);
            Console.WriteLine("Periodos usados: " + periodos);
            Console.WriteLine();
        }
    }
}
