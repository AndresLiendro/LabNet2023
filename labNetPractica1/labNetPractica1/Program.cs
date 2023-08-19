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

            for (int j = 1; j <= 2; j++)
            {
                string tipoTransporte = (j == 1) ? "Ómnibus" : "Taxi";

                for (int i = 0; i < 5; i++)
                {
                    int NumeroTransporte = random.Next(1, 100);
                    int pasajeros;

                    Console.WriteLine("Ingrese la cantidad de pasajeros para el " + tipoTransporte+ " N°" + NumeroTransporte);
                    pasajeros = int.Parse(Console.ReadLine());

                    if (j == 1)
                    {
                        transportes.Add(new Omnibus(pasajeros, NumeroTransporte));
                    }
                    else
                    {
                        transportes.Add(new Taxi(pasajeros, NumeroTransporte));
                    }
                }

                foreach (var transporte in transportes)
                {
                    if (transporte.TienePasajeros())
                    {
                        transporte.Avanzar();
                    }
                    else
                    {
                        Console.WriteLine($"El transporte con N°: {transporte.ObtenerNumTransporte()} no puede avanzar sin pasajeros");
                        transporte.Detenerse();
                    }
                }
            }            

            Console.ReadLine();
        }
    }
}
