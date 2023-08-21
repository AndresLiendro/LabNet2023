using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases
{
    public class Operaciones
    {
        public static decimal DivisionEj1 (decimal _dividendo)
        {
            decimal division;
            decimal divisor = 0;

            division = (_dividendo / divisor);

            return division;
        }

        public static decimal DivisionEj2 (decimal dividendo, decimal divisor)
        {
            decimal operacion;
            operacion = (dividendo / divisor);

            MensajesGenericos.Mensajes.MensajeResultadoDiv(operacion);

            return operacion;
        }
    }
}
