using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Validaciones
{
    internal class Validaciones
    {
        public static decimal Validacion(string mensaje)
        {

            decimal valor;
            string validar;

            Console.WriteLine(mensaje);

            validar = Console.ReadLine();

            while (!decimal.TryParse(validar, out valor))
            {

                Console.WriteLine(mensaje);
                validar = Console.ReadLine();
            }

            return valor;
        }
    }
}
