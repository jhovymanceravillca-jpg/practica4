using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            const int MONTO_MINIMO = 1;
            const int MONTO_MAXIMO = 5000;
            int monto;

            do
            {
                Console.Write("Ingresa monto en bolivianos (1 a 5000): ");
                monto = int.Parse(Console.ReadLine());

                if (monto < MONTO_MINIMO || monto > MONTO_MAXIMO)
                {
                    Console.WriteLine("Error: El rango permitido es de 1 a 5000 bolivianos.");
                }
            } while (monto < MONTO_MINIMO || monto > MONTO_MAXIMO);

            Console.WriteLine("Monto valido registrado: " + monto);
            Console.ReadLine();
        }
    }
}
