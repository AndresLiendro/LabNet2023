using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductsFirstUI
    {
        public static void ObtenerPrimerProducto()
        {
            AppClean.ClearConsole();
            ProductFirst.GetConsult();
            Tries.TryAgain();
        }
    }
}
