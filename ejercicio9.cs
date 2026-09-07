using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio9
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int minimo = 0;
            int idMax = 0;
            int idMin = 0;

            for (int i = 1; i <=7; i++)
            {
                Console.Write("Valor del objeto historico " + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maximo = valor;
                    minimo = valor;
                    idMax = i;
                    idMin = i;
                }
                else
                {
                    if (valor > maximo)
                    {
                        maximo = valor;
                        idMax = i;
                    }
                    if (valor < minimo)
                    {
                        minimo = valor;
                        idMin = i;
                    }
                }
            }
            Console.WriteLine("Maximo: " + maximo + " en objeto " + idMax);
            Console.WriteLine("Minimo: " + minimo + " en objeto " + idMin);
            Console.ReadLine();
        }
    }
}
