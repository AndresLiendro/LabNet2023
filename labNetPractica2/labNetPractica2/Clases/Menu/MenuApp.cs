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

                    Console.Clear();
                    MensajesGenericos.Mensajes.MensajeDividendo();
                    decimal dividendoIngresado = Validaciones.Validaciones.Validacion("Solo se permiten números: ");
                    Ejercicio.PrimerEjercicio(dividendoIngresado);
                    break;

                case 2:

                    Console.Clear();
                    MensajesGenericos.Mensajes.MensajeDividendo();
                    decimal dividendo = Validaciones.Validaciones.Validacion("Solo se permiten números: ");

                    MensajesGenericos.Mensajes.MensajeDivisor();
                    decimal divisor = Validaciones.Validaciones.Validacion("Solo se permiten números: ");
                    Ejercicio.SegundoEjercicio(dividendo, divisor);
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Ejercicio N°3");
                    Logic.Captura();
                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("Ejercicio N° 4");
                    Logic.CapturaExcepcionPersonalizada();
                    break;

                default:

                    Console.WriteLine("Opcion no valida. Ingrese una de las opciones brindadas");
                    decimal opDefault = Validaciones.Validaciones.Validacion("Solo se permiten números");
                    Menu(opDefault);
                    break;
            }
        }
    }
}
