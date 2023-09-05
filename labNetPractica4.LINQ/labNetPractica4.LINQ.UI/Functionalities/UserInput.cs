using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Functionalities
{
    public class UserInput
    {
        public static int OnlyNumbers()
        {
            int input = EntryValidations.Validation("Solo se permiten numeros");
            return input;
        }
    }
}
