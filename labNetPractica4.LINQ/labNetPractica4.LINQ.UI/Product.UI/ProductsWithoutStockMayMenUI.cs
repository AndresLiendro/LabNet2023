using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductsWithoutStockMayMenUI
    {
        public static void ObtenerProductSinStockMayorMenor()
        {
            try
            {
                AppClean.ClearConsole();
                ProductWithoutStockMayMen productSinStockMayorMenor = new ProductWithoutStockMayMen();
                var productSinStockMayorMenorList = productSinStockMayorMenor.GetConsulta();
                ImprimerProductSinStockMayorMenor(productSinStockMayorMenorList);
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

        public static void ImprimerProductSinStockMayorMenor(IEnumerable<ProductsWithoutStockMayMenDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageProductsWithoutStockMayMen(item);
            }
        }
    }
}
