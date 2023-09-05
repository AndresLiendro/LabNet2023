using labNetPractica4.LINQ.ENTITIES;
using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductsWithoutStockUI
    {
        public static void ObtenerProductosSinStock()
        {
            try
            {
                AppClean.ClearConsole();
                ProductWithoutStock product = new ProductWithoutStock();
                var productsList = product.GetConsulta();
                ImprimirProductoSinStock(productsList);
            }
            catch (Exception ex)
            {
                Messages.AppMessages.ExceptionMessage(ex);
            }
            finally
            {
                Tries.TryAgain();
            }
        }

        public static void ImprimirProductoSinStock(IEnumerable<Products> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageProductsWithoutStock(item);
            }
        }
    }
}
