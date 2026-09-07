using System;
using System.Collections.Generic;
using System.Text;

namespace practica4
{
    internal class ejercicio11
    {
        static void Main(string[] args)
        {
            int opcionPrincipal;
            int urgentes = 0;

            do
            {
                Console.WriteLine("1) Registrar tramo");
                Console.WriteLine("2) Consultar meta");
                Console.WriteLine("3) Salir");
                opcionPrincipal = int.Parse(Console.ReadLine());

                if (opcionPrincipal == 1)
                {
                    Console.WriteLine("Seleccione zona: 1) Norte 2) Sur");
                    int zona = int.Parse(Console.ReadLine());

                    if (zona == 1 || zona == 2)
                    {
                        Console.WriteLine("Es urgente? 1) Si 2) No");
                        int urgente = int.Parse(Console.ReadLine());

                        if (urgente == 1)
                        {
                            urgentes++;
                            Console.WriteLine("Registro urgente guardado en zona " + zona);
                        }
                        else if (urgente == 2)
                        {
                            Console.WriteLine("Registro no urgente guardado en zona " + zona);
                        }
                        else
                        {
                            Console.WriteLine("Opcion de urgencia invalida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Zona invalida.");
                    }
                }
                else if (opcionPrincipal == 2)
                {
                    Console.WriteLine("Meta del periodo en proceso.");
                }
                else if (opcionPrincipal == 3)
                {
                    Console.WriteLine("Saliendo...");
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            } while (opcionPrincipal != 3);
            Console.WriteLine("Total de registros urgentes: " + urgentes);
            Console.ReadLine();
        }
    }
}
