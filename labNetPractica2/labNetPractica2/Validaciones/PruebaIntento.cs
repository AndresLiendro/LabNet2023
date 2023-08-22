using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Validaciones
{
    public class PruebaIntento
    {
        public static void PruebaDeIntento()
        {
            Clases.MensajesGenericos.Mensajes.MensajeNuevoIntento();
            decimal IntentoNuevo = Validaciones.Validacion("Para intentar nuevamente presione 1, para cerrar presione cualquier tecla");
            Intentos.Intento(IntentoNuevo);
            Console.Clear();
        }
    }
}
