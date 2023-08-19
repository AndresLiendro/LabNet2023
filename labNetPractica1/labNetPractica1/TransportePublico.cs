using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public abstract class TransportePublico
    {
        private int pasajeros { get; set; }

        protected TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        //bandera
        public bool TienePasajeros()
        {
            return pasajeros > 0;
        }

        protected bool PorcentajePasajerosTransporte(int capacidad)
        {
            return (float)pasajeros / capacidad > 0.1;
        }

        protected int ObtenerPasajero()
        {
            return pasajeros;
        }

        public abstract int ObtenerNumTransporte();
        protected abstract int ObtenerCapacidad();

        protected abstract string TipoTransporte();

        public abstract void Avanzar();
        public abstract void Detenerse();

    }

}
