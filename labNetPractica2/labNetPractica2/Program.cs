using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clases.MensajesGenericos.Mensajes.MensajeDeConsola();

            decimal opcion = Validaciones.Validaciones.Validacion("Solo se permiten números: ");

            Clases.Menu.MenuApp.Menu(opcion);

            Console.WriteLine("Fin del Programa");
            Console.ReadLine();
        }
    }
}
