using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public  class ProductsFirstElementUI
    {
        public static void ObtenerProductPrimerElemento()
        {
            AppClean.ClearConsole();
            ProductsFirstElement productPrimerElemento = new ProductsFirstElement();
            productPrimerElemento.GetConsult();
            Tries.TryAgain();
        }
    }
}
