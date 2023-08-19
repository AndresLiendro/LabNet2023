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

        private const int CapacidadMaximaTaxi = 4;
        public Taxi(int pasajeros, int numeroTaxi) : base(pasajeros) => NumeroTransporte = numeroTaxi;
        public override void Avanzar()
        {
            Console.WriteLine($"{TipoTransporte()} N° {NumeroTransporte} con {ObtenerPasajero()} pasajeros comienza el recorrido");
        }

        public override void Detenerse()
        {
            Console.WriteLine($"El {TipoTransporte()} N° {NumeroTransporte} se detiene");
        }

        public override int ObtenerNumTransporte()
        {
            return NumeroTransporte;
        }

        protected override int ObtenerCapacidad()
        {
            return CapacidadMaximaTaxi;
        }

        protected override string TipoTransporte()
        {
            return "Taxi";
        }
    }
}
