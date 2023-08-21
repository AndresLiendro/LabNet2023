using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases
{
    public class ExcepcionesPersonalizadas : Exception
    {
        public ExcepcionesPersonalizadas(string mensaje) : base(mensaje)
        {

        }

        public override string Message => "Excepcion Personalizada";
    }
}
