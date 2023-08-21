using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases
{
    public class Ejercicio
    {
        public static void PrimerEjercicio (decimal numero)
        {
            try 
            {

                Operaciones.DivisionEj1(numero);
            } 
            catch (DivideByZeroException exDiv)
            {

                MensajesGenericos.Mensajes.MensajeDivisionEn0(exDiv.Message);
            }
            finally
            {

                Console.WriteLine("Termino la operacion.");
            }
        }

        public static void SegundoEjercicio (decimal dividendo, decimal divisor)
        {
            try
            {

                Operaciones.DivisionEj2(dividendo, divisor);
            }
            catch (DivideByZeroException ex)
            {

                MensajesGenericos.Mensajes.MensajeDivisionEn0(ex.Message);
            }
            finally
            {

                Console.WriteLine("Termino la operacion.");
            }
        }
    }
}
