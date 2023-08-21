using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Validaciones
{
    public static class Intentos
    { 
        public static void Intento(decimal opcion)
        {

            if (opcion == 1)
            {

                Clases.MensajesGenericos.Mensajes.MensajeDeConsola();
                decimal numero = Validaciones.Validacion("Ingrese solo números");
                Clases.Menu.MenuApp.Menu(numero);
            }
        }
    }
}
