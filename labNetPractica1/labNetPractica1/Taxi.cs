using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Taxi : TransportePublico
    {
        public int NumeroTransporte { get; set; }
        public Taxi(int pasajeros, int numeroTaxi) : base(pasajeros) => NumeroTransporte = numeroTaxi;
        public override void Avanzar()
        {
            int capacidad = ObtenerCapacidad();

            string tipoTransporte = TipoTransporte();

            if (TienePasajeros())
            {
                Console.WriteLine($"{tipoTransporte} N° {NumeroTransporte} con {ObtenerPasajero()} pasajeros comienza el recorrido");
            }
            else
            {
                Console.WriteLine($"El {tipoTransporte} N° {NumeroTransporte} no puede iniciar su recorrido sin pasajeros");
            }
        }

        public override void Detenerse()
        {
            string tipoTransporte = TipoTransporte();

            Console.WriteLine($"El {tipoTransporte} N° {NumeroTransporte} se detiene");
        }

        public override int ObtenerNumTransporte()
        {
            return NumeroTransporte;
        }

        protected override int ObtenerCapacidad()
        {
            return 4;
        }

        protected override string TipoTransporte()
        {
            return "Taxi";
        }
    }
}
