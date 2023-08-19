using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            List<TransportePublico> transportes = new List<TransportePublico>();


            int Seleccion;
            string tipoTransporte;

            do
            {
                Console.Clear();

                Console.WriteLine("Seleccione el tipo de transporte");
                Console.WriteLine("\n1. Omnibus");
                Console.WriteLine("2. Taxi");
                Console.WriteLine("0. Salir");

                //Manejo y uso de variable
                while (!int.TryParse(Console.ReadLine(), out Seleccion) || Seleccion < 0 || Seleccion > 2)
                {
                    Console.WriteLine("Opcion no valida.");
                }

                if (Seleccion != 0)
                {
                    tipoTransporte = (Seleccion == 1) ? "Omnibus" : "Taxi";

                    for (int i = 0; i < 5; i++)
                    {
                        int numeroTransporte = random.Next(1, 100);
                        Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipoTransporte} N°{numeroTransporte}");

                        int pasajeros = int.Parse(Console.ReadLine());

                        if (Seleccion == 1)
                        {
                            transportes.Add(new Omnibus(pasajeros, numeroTransporte));
                        }
                        else
                        {
                            transportes.Add(new Taxi(pasajeros, numeroTransporte));
                        }
                    }
                }

                Console.Clear();

                foreach (var transporte in transportes)
                {
                    Console.WriteLine("Transporte Ingresado");

                    string tipo = (transporte is Taxi) ? "Taxi" : "Omnibus";

                    Console.WriteLine($"{tipo} - Numero de Transporte: {transporte.ObtenerNumTransporte()} - Con {transporte.ObtenerPasajero()} pasajeros.");

                    bool bandera = true;

                    while (bandera)
                    {
                        int Opcion;

                        Console.WriteLine($"Accion para el transporte: {transporte.ObtenerNumTransporte()}");
                        Console.WriteLine("1. Avanzar");
                        Console.WriteLine("2. Detenerse");
                        Console.WriteLine("0. Salir\n");
                        Console.Write("Opción: ");

                        while (!int.TryParse(Console.ReadLine(), out Opcion) || Opcion < 0 || Opcion > 2)
                        {
                            Console.WriteLine("Opcion no valida.");
                        }

                        switch (Opcion)
                        {
                            case 1:
                                transporte.Avanzar();
                                break;
                            case 2:
                                transporte.Detenerse();
                                bandera = false;
                                break;
                            case 0:
                                Console.WriteLine("Saliendo");
                                bandera = false;
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente nuevamente.");
                                break;
                        }
                        Console.WriteLine();
                    }
                }

                transportes.Clear();

            } while (Seleccion != 0);

            Console.WriteLine("Presione cualquier tecla para cerrar.");
            Console.ReadLine();
        }
    }
}
    