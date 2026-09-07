using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio6
    {
        static void Main(string[] args)
        {
            const int RESERVA_INICIAL = 12000;
            const int ENTREGA_JORNADA = 1500;
            const double PORCENTAJE_ALERTA = 0.20;
            int reserva = RESERVA_INICIAL;
            int jornadas = 0;

            while(reserva > 0)
            {
                reserva -= ENTREGA_JORNADA;
                if (reserva < 0) reserva = 0;
                jornadas++;
                Console.WriteLine("Jornada " + jornadas + " - Reserva restante: " + reserva);

                if (reserva < RESERVA_INICIAL * PORCENTAJE_ALERTA && reserva > 0)
                {
                    Console.WriteLine("Alerta: Reserva baja al 20%.");
                }
            }
            Console.WriteLine("Reserva agotada en " + jornadas + " jornadas.");
            Console.ReadLine();
        }
    }
}
