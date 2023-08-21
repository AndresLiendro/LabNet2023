using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases.Menu
{
    public class MenuApp
    {
        public static void Menu(decimal opcion) 
        {
            switch (opcion)
            {
                case 1:

                    MensajesGenericos.Mensajes.MensajeDividendo();
                    decimal dividendoIngresado = Validaciones.Validaciones.Validacion("Solo se permiten números: ");
                    Ejercicio.PrimerEjercicio(dividendoIngresado);
                    break;

                case 2:

                    MensajesGenericos.Mensajes.MensajeDividendo();
                    decimal dividendo = Validaciones.Validaciones.Validacion("Solo se permiten números: ");

                    MensajesGenericos.Mensajes.MensajeDivisor();
                    decimal divisor = Validaciones.Validaciones.Validacion("Solo se permiten números: ");
                    Ejercicio.SegundoEjercicio(dividendo, divisor);
                    break;

                case 3:

                    Console.WriteLine("Ejercicio N°3: ");
                    Clases.Logic.Captura();
                    break;

                default:
                    break;
            }
        }
    }
}
