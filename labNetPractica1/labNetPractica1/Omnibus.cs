using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Omnibus : TransportePublico
    {
        public int NumeroTransporte { get; set; }

        private const int CapacidadMaximaBus = 110;
        public Omnibus(int pasajeros, int numeroOmnibus) : base(pasajeros)
        {
            NumeroTransporte = numeroOmnibus; 
        }

        public override void Avanzar()
        {

            Console.WriteLine("{0} N° {1} con {2} pasajeros comienza el recorrido", TipoTransporte(), NumeroTransporte, ObtenerPasajero());
            
        }

        public override void Detenerse()
        {
            Console.WriteLine("El {0} N° {1} deteniendose", TipoTransporte(), NumeroTransporte);
        }

        public override int ObtenerNumTransporte()
        {
            return NumeroTransporte;
        }

        protected override int ObtenerCapacidad()
        {
            return CapacidadMaximaBus;
        }

        protected override string TipoTransporte()
        {
            return "Omnibus";
        }
    }
}
