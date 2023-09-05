using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Functionalities
{
    public class EntryValidations
    {
        public static int Validation(string message)
        {
            int valor;
            Console.WriteLine(message);
            string validNumber = Console.ReadLine();

            while (!int.TryParse(validNumber, out valor))
            {
                Console.WriteLine(message);
                validNumber = Console.ReadLine();
            }

            return valor;
        }
    }
}
