using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            const int META_FAMILIAS = 1200;
            int comunidades = 1;
            int sumafamilias = 0;
            
            while (comunidades <= 5)
            {
                Console.WriteLine("Familias con bano ecologico en comunidad " + comunidades + ": ");
                int familias = int.Parse(Console.ReadLine());
                sumafamilias += familias;
                comunidades++;
            }

            if (sumafamilias >= META_FAMILIAS)
            {
                Console.WriteLine("Se alcanzo la meta de " + META_FAMILIAS + " familias. ");
            }
            else
            {
                Console.WriteLine("No se alcanzo la meta. Total: " + sumafamilias);
            }
            Console.ReadLine();
        }
    }
}
