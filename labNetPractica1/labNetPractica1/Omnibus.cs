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
        public Omnibus(int pasajeros, int numeroOmnibus) : base(pasajeros)
        {
            NumeroTransporte = numeroOmnibus; 
        }

        public override void Avanzar()
        {
            int capacidad = ObtenerCapacidad();
            string tipoTranspote = TipoTransporte();
            if (TienePasajeros())
            {
                Console.WriteLine("{0} N° {1} con {2} pasajeros comienza el recorrido", tipoTranspote, NumeroTransporte, ObtenerPasajero());
            }
            else
            {
                Console.WriteLine("El {0} N° {1} no puede iniciar su recorrido sin Pasajeros", tipoTranspote, NumeroTransporte);
            }
        }

        public override void Detenerse()
        {
            string tipoTranspote = TipoTransporte();
            Console.WriteLine("El {0} N° {1} deteniendose", tipoTranspote, NumeroTransporte);
        }

        public override int ObtenerNumTransporte()
        {
            return NumeroTransporte;
        }

        protected override int ObtenerCapacidad()
        {
            return 110;
        }

        protected override string TipoTransporte()
        {
            return "Omnibus";
        }
    }
}
