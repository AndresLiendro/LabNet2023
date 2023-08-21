using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases
{
    public class Logic
    {
        public static void LanzarExcepcion()
        {
            throw new FormatException();
        }

        public static void LanzarExcepcionPersonalizada()
        {
            string msjPersonalizado = "Mensaje de Excepcion personalizado";
            throw new ExcepcionesPersonalizadas(msjPersonalizado);
        }

        public static void Captura()
        {
            try
            {
                LanzarExcepcion();
            }
            catch (DivideByZeroException exDiv)
            {

                Console.WriteLine(exDiv.Message);
                MensajesGenericos.Mensajes.MensajeDeTipo(exDiv);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MensajesGenericos.Mensajes.MensajeDeTipo(ex);
            }
            finally
            {

                Console.WriteLine("Termino la operacion.");
                Validaciones.PruebaIntento.PruebaDeIntento();
            }
        }
    }
}
