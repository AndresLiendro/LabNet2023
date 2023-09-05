using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductsOrderByNameUI
    {
        public static void ObtenerProductOrderByName()
        {
            try
            {
                AppClean.ClearConsole();
                ProductsOrderByName productOrderByName = new ProductsOrderByName();
                var productOrderByNameList = productOrderByName.GetConsulta();
                PrintProductsOrderByName(productOrderByNameList);

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

        public static void PrintProductsOrderByName(IEnumerable<ProductsOrderByNameDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageProductOrderByName(item);
            }
        }
    }
}
