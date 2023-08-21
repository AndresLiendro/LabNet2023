using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases.MensajesGenericos
{
    public class Mensajes
    {
        public static void MensajeDeConsola()
        {
            Console.WriteLine("1. Ejercicio N-1");
            Console.WriteLine("2. Ejercicio N-2");
            Console.WriteLine("3. Ejercicio N-3");
            Console.WriteLine("4. Ejercicio N-4");
        }

        public static void MensajeSeleccionNoValida()
        {
            Console.WriteLine("Opcion no valida, por favor ingrese una opcion valida");
        }

        public static void MensajeDividendo()
        {
            Console.WriteLine("Ingrese número dividendo: ");
        }

        public static void MensajeDivisor()
        {
            Console.WriteLine("Ingrese número divisor: ");
        }

        public static void MensajeDivisionEn0(string mensaje)
        {
            string mensajeDiv0 = "\nSolo Chuck Norris y Goku pueden dividir por 0!";
            Console.WriteLine($"{mensaje} {mensajeDiv0}");
        }

        public static void MensajeResultadoDiv(decimal resultado)
        {
            Console.WriteLine($"El resultado de la division es: {resultado}");
        }

        public static void MensajeNuevoIntento()
        {
            Console.WriteLine("¿Quiere intentar de nuevo?");
        }
    }
}
