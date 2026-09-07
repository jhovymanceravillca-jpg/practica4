using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio8
    {
        static void Main(string[] args)
        {
            int documento = 1;
            int pares = 0;
            int impares = 0;

            while (documento <= 5)
            {
                if (documento % 2 == 0)
                {
                    Console.WriteLine("Documento " + documento + " se inspecciona por la manana.");
                    pares++;
                }
                else
                {
                    Console.WriteLine("Documento " + documento + " se inspecciona por la tarde.");
                    impares++;
                }
                documento++;
            }
            Console.WriteLine("Turno manana (pares): " + pares + " | Turno tarde (impares): " + impares);
            Console.ReadLine();
        }
    }
}
