using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace practica4
{
    internal class ejercicio20
    {
        static void Main(string[] args)
        {
            const int TOTAL_TRAMOS = 5;
            const int MIN_SINIESTROS = 0;
            const int MAX_SINIESTROS = 40;
            const int ENTREGA_SIMULACION = 6;
            const int PELIGROSO = 30;
            const int RIESGO_MEDIO = 15;
            int opcionMenu;
            int totalSiniestros = 0;

            do
            {
                Console.WriteLine("1) Carga tramos 2) Reporte 3) Simulacion 4) Salir");
                opcionMenu = int.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    totalSiniestros = 0;
                    for (int i = 1; i <= TOTAL_TRAMOS; i++)
                    {
                        int valor;
                        do
                        {
                            Console.Write("Siniestros tramo " + i + " (0-40): ");
                            valor = int.Parse(Console.ReadLine());
                        } while (valor < MIN_SINIESTROS || valor > MAX_SINIESTROS);

                        totalSiniestros += valor;
                    }
                }
                else if (opcionMenu == 2)
                {
                    if (totalSiniestros > 0)
                    {
                        double promedio = (double)totalSiniestros / TOTAL_TRAMOS;
                        if (promedio >= PELIGROSO)
                        {
                            Console.WriteLine("TRAMO PELIGROSO");
                        }
                        else if (promedio >= RIESGO_MEDIO)
                        {
                            Console.WriteLine("RIESGO MEDIO");
                        }
                        else
                        {
                            Console.WriteLine("TRAMO SEGURO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay datos cargados.");
                    }
                }
                else if (opcionMenu == 3)
                {
                    int copiaSiniestros = totalSiniestros;
                    int jornadas = 0;
                    while (copiaSiniestros >= ENTREGA_SIMULACION)
                    {
                        copiaSiniestros -= ENTREGA_SIMULACION;
                        jornadas++;
                    }
                    Console.WriteLine("Cobertura en " + jornadas + " jornadas.");
                }
                else if (opcionMenu == 4)
                {
                    Console.WriteLine("Resumen general. Total cargado: " + totalSiniestros);
                }
            } while (opcionMenu != 4);

            Console.ReadLine();
        }
    }
}
